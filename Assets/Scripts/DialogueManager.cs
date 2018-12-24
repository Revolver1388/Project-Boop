using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;


    private Queue<string> Sentences;

	
	void Start ()
    {
        Sentences = new Queue<string>();
	}
	
    public void StartDialogue (Dialogue conversation)
    {

        nameText.text = conversation.name;

        Sentences.Clear();

        foreach (string sentence in conversation.Sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = Sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
	
}
