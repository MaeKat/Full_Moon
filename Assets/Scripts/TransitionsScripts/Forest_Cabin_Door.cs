﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest_Cabin_Door : MonoBehaviour
{

    public LevelLoader sn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Debug.Log("doorhit");
            sn.LoadPitfall(7);
        }
    }

}
