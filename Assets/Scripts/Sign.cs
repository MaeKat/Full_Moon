using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{


    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Player")){
            Debug.Log("Player in range");

        }
    }
    private void OnTriggerExit2D(Collider2D other){

        if(other.CompareTag("Player")){
            Debug.Log("Player left range");

        }
    }


}
