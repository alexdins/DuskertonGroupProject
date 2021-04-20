using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    

    public void TriggerDialogue(string npc)
    {

        FindObjectOfType<DialogueManager>().StartDialogue(npc);

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue(gameObject.tag);
        }
        
    }

}
