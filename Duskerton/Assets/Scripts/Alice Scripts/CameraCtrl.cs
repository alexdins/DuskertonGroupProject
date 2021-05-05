using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public CharacterController control;
    public GameObject pcArms;
    public Camera[] views;
    
    public float mouseSpeed = 100f;
    public int currCam = 0;
    float xRot = 0f;

    void Start()
    {
        currCam = 0;
        views[0].enabled = true; //Third Person View
        views[1].enabled = false; //First Person View
        pcArms.SetActive(false);
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            int setCam = 0;

            if (currCam == 0) setCam = 1;
            else if (currCam == 1) setCam = 0;
            else Debug.LogError("currCam exceeds definitions!");

            Cursor.lockState = CursorLockMode.Locked;

            pcArms.SetActive(false);
            views[currCam].enabled = false;
            views[setCam].enabled = true;
            currCam = setCam;

            if (views[1].enabled)
            {
                pcArms.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
        }

        if (views[1].enabled == true)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

            xRot -= mouseY;
            xRot = Mathf.Clamp(xRot, -90f, 45f);

            views[1].transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}
