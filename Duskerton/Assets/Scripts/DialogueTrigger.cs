using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    

    public void TriggerDialogue()
    {

        FindObjectOfType<DialogueManager>().StartDialogue();

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
        }
    }

}
