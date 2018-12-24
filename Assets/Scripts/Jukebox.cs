using System.Collections;
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
//place on jukebox trigger