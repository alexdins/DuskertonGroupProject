using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    public void StartDialogue ()
    {
        Fungus.Flowchart.BroadcastFungusMessage("Bob Start");
        

    }

    
    
}
