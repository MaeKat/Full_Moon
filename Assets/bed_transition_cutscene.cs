using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bed_transition_cutscene: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (JumpToScene());
    }

    IEnumerator JumpToScene() {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Cutscene 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
