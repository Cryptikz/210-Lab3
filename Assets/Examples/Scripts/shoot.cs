﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        //instantiation inside player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempbullet = Instantiate(bullet, transform.position, Quaternion.identity);
        }

    }
}
