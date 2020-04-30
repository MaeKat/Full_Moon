using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && MtnKey.HasKey >= 2)
        { //Add Door collision here!
            MtnKey.HasKey = 0;
            Debug.Log("doorhit");
            Destroy(gameObject);
        }
    }
}
