using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;
    public GameObject TextBox;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        

    }

    public void StartDialogue (Dialogue dialogue)
    {
        
        nameText.SetText(dialogue.name);
        TextBox.SetActive(true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }
        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.SetText(sentence);
    }

    void EndDialogue()
    {
        TextBox.SetActive(false);
        
    }
    
}
