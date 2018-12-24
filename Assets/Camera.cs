using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public Transform highWall;
    public Transform lowWall;
    public Transform rightWall;
    public Transform leftWall;

    private float yMax;
    private float yMin;
    private float xMax;
    private float xMin;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
        Physics2D.IgnoreCollision(player.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
    }

    void Update()
    {
        yMax = highWall.transform.position.y;
        yMin = lowWall.transform.position.y;
        xMax = rightWall.transform.position.x;
        xMin = leftWall.transform.position.x;

        if (player.transform.position.y < yMax && player.transform.position.y > yMin)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -110.0f);
        }

        if (player.transform.position.y > yMax)
        {
            transform.position = new Vector3(player.transform.position.x, yMax, -110.0f);
        }
        else if (player.transform.position.y < yMin)
        {
            transform.position = new Vector3(player.transform.position.x, yMin, -110.0f);
        }

        if (player.transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, player.transform.position.y, -110.0f);
        }
        else if (player.transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, player.transform.position.y, -110.0f);
        }

        if (player.transform.position.y > yMax && player.transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, yMax, -110.0f);
        }
        if (player.transform.position.y > yMax && player.transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, yMax, -110.0f);
        }
        if (player.transform.position.y < yMin && player.transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, yMin, -110.0f);
        }
        if (player.transform.position.y < yMin && player.transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, yMin, -110.0f);
        }
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}

