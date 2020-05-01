using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene3: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (JumpToScene());
    }

    IEnumerator JumpToScene() {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Internal_Mountain_1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
