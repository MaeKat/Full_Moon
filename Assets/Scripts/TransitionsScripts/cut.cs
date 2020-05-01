using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (JumpToScene());
    }

    IEnumerator JumpToScene() {
        yield return new WaitForSeconds(20.0f);
        SceneManager.LoadScene("Main_Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
