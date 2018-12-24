using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Fodder : MonoBehaviour {

    public bool canSpeak;

    public void Talk()
    {
        if(canSpeak)
        {
            //Talking Happens
        }
    }

	void Start () {
        canSpeak = false;
	}

	void Update () {
		
	}
}
