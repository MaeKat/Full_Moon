using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public LevelLoader sn;
    // Start is called before the first frame update
    void Start()
    {
        //sn = GetComponent<LevelChanger>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { //Add Door collision here!
            Debug.Log("doorhit");
            sn.LoadNextLevel();
        }
    }
}
