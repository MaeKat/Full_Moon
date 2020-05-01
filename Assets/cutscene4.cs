using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene4: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (JumpToScene());
    }

    IEnumerator JumpToScene() {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Boss_Fight_Scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
