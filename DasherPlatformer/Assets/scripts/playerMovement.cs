using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float horizontalMove;
    public CharacterController2D controller;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");//input from user float between -1 and 1

    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove, false, false);
    }
}
