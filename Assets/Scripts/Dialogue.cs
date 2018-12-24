using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    public string name;

    [TextArea(5,12)]
    public string[] Sentences;

    void Start()
    {
        Sentences = new string[] {"Hey.", "You're silly.", "Bye." , "I will punch you"};
    }

}
