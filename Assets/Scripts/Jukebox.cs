using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox : MonoBehaviour {

    public AudioSource src;
    public AudioClip[] music;

    public GameObject songL1;
    public GameObject songL2;
    public GameObject turnOff1;
    int i = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag == "Player")
        {
            songL1.SetActive(true);
            songL2.SetActive(true);
            turnOff1.SetActive(true);
        }
          
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            songL1.SetActive(false);
            songL2.SetActive(false);
            turnOff1.SetActive(false);
        }
    }
    void Start()
    {
        if (!GetComponent<AudioSource>())
        {
            gameObject.AddComponent<AudioSource>();
        }
        src = GetComponent<AudioSource>();
    }

  public  void song1()
    {
        src.Stop();
        src.PlayOneShot(music[0]);
    }
    public void song2()
    {
        src.Stop();
        src.PlayOneShot(music[1]);
    }
    public void turnOff()
    {
        src.Stop();
    }
}

/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox : MonoBehaviour {

    public AudioSource src;
    public AudioClip[] music;
    int i = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (!src.isPlaying)
        {
            if (other.tag == "Player")
            {
                src.PlayOneShot(music[i]);
            }
        }
        else if (src.isPlaying)
        {
            src.Stop();
            i += 1;
            if (i >= 2)//i cannot be larger than the size of your music[] 
            {
                i = 0;
            }
            src.PlayOneShot(music[i]);
        }
    }

    void Start()
    {
        if (!GetComponent<AudioSource>())
        {
            gameObject.AddComponent<AudioSource>();
        }
        src = GetComponent<AudioSource>();
    }
}
*/
//place on jukebox trigger
