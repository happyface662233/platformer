using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class cameraFollow : MonoBehaviour

{
    Vector3 newPos;
    [SerializeField] public Transform player;
    Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         newPos = transform.position;
        newPos.x = player.position.x;
        transform.position = newPos;
    }
}
