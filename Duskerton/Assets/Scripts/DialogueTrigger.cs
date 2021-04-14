using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    public Dialogue dialogue;

    public void TriggerDialogue()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (FindObjectOfType<DialogueManager>().TextBox.activeSelf)
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
                return;
            }
            TriggerDialogue();
        }
    }

}
