using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    //UI ELEMENTS
    public GameObject drunkMeter;


    //TIMER VARIABLES
    private int timeLeft = 3;
    public float timer = 0;

    void Start()
    {
        gameObject.GetComponent<PlayerBlob>().drunk = gameObject.GetComponent<PlayerBlob>().maxDrunk;
    }

    void Update()
    {
        #region DRUNK METER //Everything pertaining to the drunk Meter is in here

        if (gameObject.GetComponent<PlayerBlob>().drunk > 0)
        {
            drunkMeter.transform.localScale = new Vector3(gameObject.GetComponent<PlayerBlob>().drunk / gameObject.GetComponent<PlayerBlob>().maxDrunk, .3f, .1f);
        }

        if (gameObject.GetComponent<PlayerBlob>().drunk <= 0)
        {
            gameObject.GetComponent<PlayerBlob>().Lose();
        }
        time();
        #endregion
    }
    void time()
    {

        timer += Time.deltaTime;
        if (timer > timeLeft)
        {
            gameObject.GetComponent<PlayerBlob>().drunk--;
            timer = 0;
        }
    }
}


        