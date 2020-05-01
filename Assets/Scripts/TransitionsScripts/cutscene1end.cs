using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene1end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (JumpToScene());
    }

    IEnumerator JumpToScene() {
        yield return new WaitForSeconds(15.0f);
        SceneManager.LoadScene("Alfie_Room_wolf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
