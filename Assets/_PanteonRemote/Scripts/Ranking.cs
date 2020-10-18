using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ranking : MonoBehaviour
{
    public GameObject FinishCanvas;
    public TextMeshProUGUI rankingText;
    public List<GameObject> bots = new List<GameObject>();
    float[] botsPosZ = new float[11];
    float backUp;
    GameObject backUpBot;
    void FixedUpdate()
    {
        for (int i = 0; i < 11; i++)
        {
            if(bots[i])
            {
                botsPosZ[i] = bots[i].transform.position.z;
            }
            else
            {
                FinishCanvas.SetActive(true);
            }            
        }
        for (int i = 0; i < 11; i++)
        {
            for (int j = i + 1; j < 11; j++)
            {
                if (botsPosZ[j] > botsPosZ[i])
                {
                    backUp = botsPosZ[i];
                    backUpBot = bots[i];
                    
                    botsPosZ[i] = botsPosZ[j];
                    bots[i] = bots[j];

                    botsPosZ[j] = backUp;
                    bots[j] = backUpBot;                   
                }   
            }
            if (bots[i].name == "Boy")
            {
                rankingText.text = i + 1 + "/11";
            }
        }        
    }
}
