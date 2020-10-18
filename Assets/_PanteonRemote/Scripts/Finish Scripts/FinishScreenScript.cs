using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FinishScreenScript : MonoBehaviour
{
    public GameObject character;
    public GameObject Bots;
    public GameObject Joystick;
    public TextMeshProUGUI rankingText;
    public TextMeshProUGUI finishRankText;
    public TextMeshProUGUI finishText;
    public GameObject canvas;
    public ParticleSystem confettiEfect;
    int confettiCounter;
    void Start()
    {
        canvas.SetActive(false);
        InvokeRepeating("FinishFunc",5,0.1f);
    }
    void FinishFunc()
    {
        if(character.transform.position.z>transform.position.z)
        {
            Bots.SetActive(false);
            Joystick.SetActive(false);
            canvas.SetActive(true);            
            finishRankText.text = rankingText.text;
            if (finishRankText.text.Equals("1/11"))
            {
                finishText.text = "YOU WON";
            }
            else
            {
                finishText.text = "YOU LOSE";
            }
            Invoke("confettiEffectFunc", 0.5f);
        }
    }
    public void PlayAgain()
    {
        DOTween.KillAll();
        SceneManager.LoadScene("SampleScene");        
    }
    void confettiEffectFunc()
    {
        if(confettiCounter<1)
        {
            confettiEfect.Play();
        }
        confettiCounter++;
    }
}
