using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    MoveCtrl MoveCtrl;
    GameObject PC;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        PC = GameObject.Find("Player Character");
        MoveCtrl = PC.GetComponent<MoveCtrl>();

    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);

        if (!isWalking && MoveCtrl.moving)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !MoveCtrl.moving)
        {
            animator.SetBool(isWalkingHash, false);
        }
    }
}
