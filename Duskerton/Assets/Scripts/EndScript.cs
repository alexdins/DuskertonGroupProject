using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public Canvas endScreen;
    public GameObject PC;

    public void Start()
    {
        endScreen.enabled = false;
    }
    public void GameEnd()
    {
        CameraCtrl cam = PC.GetComponent<CameraCtrl>();
        MoveCtrl move = PC.GetComponent<MoveCtrl>();
        Cursor.lockState = CursorLockMode.None;
        cam.CamChange();

        move.enabled = false;
        cam.enabled = false;

        endScreen.enabled = true;
    }
}
