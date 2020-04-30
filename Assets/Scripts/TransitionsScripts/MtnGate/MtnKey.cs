using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MtnKey : MonoBehaviour
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
