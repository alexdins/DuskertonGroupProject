using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public CharacterController control; 
    public Camera[] views;
    public int currCam;

    public float speed = 12f;
    public float turnSmoothTime = 0.1f; 
    public float MouseSpeed;
        
    float turnSmoothVelocity;
    float xRot = 0f;

    void Start()
    {
        currCam = 0;
        views[0].enabled = true; //Third Person View
        views[1].enabled = false; //First Person View

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0f, z).normalized; 
        
        if (Input.GetKeyDown("space"))
            SetCamera();

        if (views[1].enabled == true)
            FpsView();
        
        if (move.magnitude >= 0.1f)
        {
            Transform cam = views[currCam].transform;
            
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            control.Move(moveDir * speed * Time.deltaTime);
        }

    }

    void SetCamera() 
    {
        int setCam = 0;

        if (currCam == 0) setCam = 1;
        else if (currCam == 1) setCam = 0;
        else Debug.LogError("currCam exceeds definitions!");

        views[currCam].enabled = false;
        views[setCam].enabled = true;
        currCam = setCam;
    }

    void FpsView()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSpeed * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 45f);

        views[1].transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
