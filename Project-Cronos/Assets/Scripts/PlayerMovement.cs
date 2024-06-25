using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [Header("Player Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] float sprintMulti;

    [Header("Animation")]
    //[SerializeField] Animator animator;

    float moveX = 0f;
    float moveY = 0f;

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Inputs for player movement
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        float moveXFinal = moveX;
        float moveYFinal = moveY;
        if (Input.GetKey(KeyCode.LeftShift))
        {
             moveXFinal = moveX * sprintMulti;
             moveYFinal = moveY * sprintMulti;
            //animator.SetBool("Sprint", true);
             
        }
        else
        {
            //animator.SetBool("Sprint", false);
        }
        transform.Translate(moveXFinal * Time.deltaTime * moveSpeed, 0f, moveYFinal * Time.deltaTime * moveSpeed);

        //PlayerAnimations();
    }

    /*
    void PlayerAnimations()
    {
        bool boolMoveX = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        bool boolMoveY = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W);

        bool shouldMove = boolMoveX || boolMoveY;
        animator.SetBool("Walk",shouldMove);
    }
    */
}
