using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinishScript : MonoBehaviour
{
    
    public List<GameObject> activeObjects = new List<GameObject>();
    public GameObject character;
    public GameObject Joystick;
    public Text paintedText;
    public GameObject nextSceneCanvas;
    public Animator characterAnimator;
    public ParticleSystem confettiEfect;
    int confettiCounter;
    void Start()
    {
        InvokeRepeating("FinishFunc", 5, 0.1f);
    }
    void FinishFunc()
    {
        if (character.transform.position.z > transform.position.z)
        {
            for (int i = 0; i < activeObjects.Count; i++)
            {
                activeObjects[i].SetActive(true);
            }
            characterAnimator.SetInteger("status", -1);
            character.GetComponent<Rigidbody>().isKinematic = true;
            character.transform.DOMove(new Vector3(-0.5f, -1f, 241), 1f);
            Joystick.SetActive(false);
        }
        if(paintedText.text.Equals("100%\nPainted"))
        {
            nextSceneCanvas.SetActive(true);
            Invoke("confettiEffectFunc",0.5f);
        }
    }
    public void NextScene()
    {
        DOTween.KillAll();
        SceneManager.LoadScene("map2");
    }
    void confettiEffectFunc()
    {
        if (confettiCounter < 2)
        {
            confettiEfect.Play();
        }
        confettiCounter++;
    }
}
