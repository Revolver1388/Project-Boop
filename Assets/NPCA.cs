using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCA : MonoBehaviour {

    public bool canSpeak;
    public string name;
    public gamemanager gamey;

    //public Canvas myCanvas;

    public void Talk()
    {
        if (canSpeak)
        {
            Debug.Log(name + " is talking.");

            for (int i = 0; i < gamey.dialogues.Length; i++)
            {
                gamey.dialogues[i].SetActive(true);
            }

            //foreach (GameObject go in dialogues)
            //{
            //    go.SetActive(true);
            //}
        }
    }

    public void ShutUp()
    {
        Debug.Log(name + " is mumbling.");

        for (int i = 0; i < gamey.dialogues.Length; i++)
        {
            gamey.dialogues[i].SetActive(false);
        }

        //foreach (GameObject go in dialogues)
        //{
        //    go.SetActive(false);
        //}
    }

    void Start()
    {
        canSpeak = false;
        gamey = GameObject.Find("GameMNGR").GetComponent<gamemanager>();

        for(int i = 0; i < gamey.dialogues.Length; i++)
        {
            gamey.dialogues[i].SetActive(false);
        }

        //foreach (GameObject go in dialogues)
        //{
        //    go.SetActive(false);
        //}
    }


}
