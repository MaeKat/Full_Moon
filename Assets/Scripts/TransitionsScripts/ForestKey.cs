using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestKey : MonoBehaviour
{

    public static int HasKey;

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
            Debug.Log("gotKey");
            HasKey +=2;
            Destroy(gameObject);
        }
    }

}
