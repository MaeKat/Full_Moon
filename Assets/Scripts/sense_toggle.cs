using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sense_toggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wolf_sense;
   // public bool activateme;
    // Update is called once per frame
 void Update()
{
    
    if (Input.GetKey(KeyCode.Tab)){
        wolf_sense.SetActive(true);
    }
    else{
        wolf_sense.SetActive(false);
    }
}
}
