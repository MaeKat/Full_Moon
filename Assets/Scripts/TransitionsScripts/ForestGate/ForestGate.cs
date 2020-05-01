using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestGate : MonoBehaviour
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
        if (collision.gameObject.tag == "Player" && ForestKey.HasKey >= 2)
        { //Add Door collision here!
            ForestKey.HasKey = 0;
            Debug.Log("doorhit");
            sn.LoadPitfall(10);
        }
    }

}
