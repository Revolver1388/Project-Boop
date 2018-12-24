using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlob : MonoBehaviour {

    Rigidbody2D rb;

    bool up;
    bool down;
    bool left;
    bool right;
    //bool isControlConnected;

    float diagonalOffset;
    float horizontal;
    float vertical;
    public float drunk;
    public float maxDrunk = 10;

    public bool endgame = false;
    public bool isPaused = false;

    Vector2 north;
    Vector2 east;

    public GameObject go;
   

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        north = new Vector2(0, 8);
        east = new Vector2(8, 0);
        //drunk = 50000;
        diagonalOffset = 1.5f;
        //drunkMeter = GameObject.Find("Drunk Meter").GetComponent<RectTransform>();
	}

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.E))
        {
            Speak();
            Interact();
        }
    }

    void FixedUpdate () {

        up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        //horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");


        if (up && !left && !right)
        {
            rb.velocity = north;
        }

        else if (up && left)
        {
            rb.velocity = (north / diagonalOffset) - (east / diagonalOffset);
        }

        else if (left && !up && !down)
        {
            rb.velocity = -east;
        }

        else if (left && down)
        {
            rb.velocity = (-east / diagonalOffset) - (north / diagonalOffset);
        }

        else if (down && !left && !right)
        {
            rb.velocity = -north;
        }

        else if (down && right)
        {
            rb.velocity = (-north / diagonalOffset) + (east / diagonalOffset);
        }

        else if (right && !up && !down)
        {
            rb.velocity = east;
        }

        else if (right && up)
        {
            rb.velocity = (east / diagonalOffset) + (north / diagonalOffset);
        }

        else if (!up && !down && !left && !right)
        {
            rb.velocity = Vector2.zero;
        }
    }

    void Interact()
    {
        // add functionality here
    }

    void Speak()
    {
        go.GetComponent<NPCA>().Talk();
    }

    void Drink(float potency)
    {
        drunk += potency;
    }

    public void Lose()
    {
        //Stuff Happens
    }
}
