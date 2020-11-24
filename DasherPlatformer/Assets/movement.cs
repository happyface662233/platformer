using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class movement : MonoBehaviour
{
    float horizontalMove;
    bool jump = false;
    [SerializeField] float moveSpeed;

    public CharacterController2D controller;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");//input from user float between -1 and 1
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * moveSpeed * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
