using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public CharacterController control;
    public Camera thirdCam;
    
    public float speed = 12f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0f, z).normalized;

        if (move.magnitude >= 0.1f && thirdCam.enabled)
        {
            float moveAngle = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg + thirdCam.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, moveAngle, ref turnSmoothVelocity, turnSmoothTime
                );
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, moveAngle, 0f) * Vector3.forward;
            control.Move(moveDir * speed * Time.deltaTime);
        }

        else if (move.magnitude >= 0.1f)
{
            control.Move(move * speed * Time.deltaTime);
        }
    }
}
