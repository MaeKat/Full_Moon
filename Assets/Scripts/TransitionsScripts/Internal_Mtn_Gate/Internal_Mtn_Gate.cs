﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Internal_Mtn_Gate : MonoBehaviour
{

    //public LevelLoader sn;

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
        if (collision.gameObject.tag == "Player" && Internal_Mtn_Key.HasKey >= 2)
        { //Add Door collision here!
            Internal_Mtn_Key.HasKey = 0;
            Debug.Log("doorhit");
            Destroy(gameObject);
            
        }
    }

}
