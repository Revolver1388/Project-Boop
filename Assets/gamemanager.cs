using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {

    // Use this for initialization
    public enum GameState { play, pause, end, dialoge };
    public GameState currentState = GameState.play;
    private static gamemanager Instance;
    public GameObject pauseUI;
    public GameObject player;
    //public GameObject endUI;
    public GameObject Meter;
    public GameObject drunkTXT;
    public PlayerBlob playerScript;
    public GameObject[] dialogues;


    public static gamemanager GetInstance()
    {
        return Instance;
    }

    void Start()
    {
        //  :)
        playerScript = GameObject.Find("Player").GetComponent<PlayerBlob>();
        dialogues = GameObject.FindGameObjectsWithTag("Dialogue");

        if (Instance)
        {
            Destroy(Instance);
        }
        Instance = this;

    }

    void Update()
    {
        switch (currentState)
        {
            case GameState.play:
                Play();
                break;
            case GameState.pause:
                Pause();
                break;
            case GameState.end:
                end();
                break;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentState == GameState.play)
            {
                currentState = GameState.pause;
            }
            else if (currentState == GameState.pause)
            {
                pauseUI.SetActive(false);
                currentState = GameState.play;
            }

        }

        if (playerScript.endgame == true)
        {
            if (currentState == GameState.play)
            {
                currentState = GameState.end;
            }
            else if (currentState == GameState.end)
            {
                currentState = GameState.play;
            }
        }
    }
    void Play()
    {
        //endUI.SetActive(false);
        playerScript.enabled = true;
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    void Pause()
    {
        playerScript.enabled = false;
        pauseUI.SetActive(true);
        Time.timeScale = 0;
    }



    void end()
    {
        //endUI.SetActive(true);
    }
}

