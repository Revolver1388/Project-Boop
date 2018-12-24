using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkTrigg : MonoBehaviour {

    public NPCA parentObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {   
            parentObj.canSpeak = true;
            collision.gameObject.GetComponent<PlayerBlob>().go = parentObj.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            parentObj.canSpeak = false;
            parentObj.ShutUp();
        }
    }

    void Start () {
        parentObj = transform.parent.GetComponent<NPCA>();
	}
	
}
