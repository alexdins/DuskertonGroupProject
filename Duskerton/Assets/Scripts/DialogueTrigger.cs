using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    CameraCtrl CameraCtrl;    

    public void TriggerDialogue(string npc)
    {

        FindObjectOfType<DialogueManager>().StartDialogue(npc);

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject PC = GameObject.Find("Player Character");
            CameraCtrl = PC.GetComponent<CameraCtrl>();
            CameraCtrl.CamChange();
            TriggerDialogue(gameObject.tag);
        }
        
    }
}
