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

    public void StartDialogue (string npc)
    {
        if (npc.Equals("Crawford"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Crawford Start");
        }
        else if (npc.Equals("Howie"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Howie Start");
        }
        else if (npc.Equals("Luca"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Luca Start");
        }
        else if (npc.Equals("Agnes"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Agnes Start");
        }

        

    }

    
    
}
