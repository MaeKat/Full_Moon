using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Internal_Mtn_Key : MonoBehaviour
{
      public static int HasKey;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Debug.Log("gotKey");
            HasKey +=2;
            Destroy(gameObject);
        }
    }
}
