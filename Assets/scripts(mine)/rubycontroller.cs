﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubycontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
     

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Verticle");
        
        Vector2 position = transform.position;
        position.x = position.x + 0.3f * horizontal * Time.deltaTime;
        position.y = position.y + 0.3f * vertical * Time.deltaTime;  
        transform.position = position;
       
    }
}
