﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator transition;
    public float transitionTime = 1f;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
       // if(Input.GetMouseButtonDown(0)){
       //     LoadNextLevel();
       // }
    }
    public void LoadNextLevel(){

        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    public void LoadPitfall(int levelIndex){
         StartCoroutine(LoadLevel(levelIndex));
       
    }

    IEnumerator LoadLevel(int levelIndex){

        //play anim
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

        if (levelIndex == 13){//mtn pass 1 pitfall
            player.position = new Vector2(0f, 0f);
            Camera.main.transform.position = new Vector3(0f, 0f, -10f); 
        }
        if (levelIndex == 14){//mtn pass 2 pitfall
            player.position = new Vector2(-31.37f, -48.16f);
            Camera.main.transform.position = new Vector3(0f, 0f, -10f); 
        }
        if (levelIndex == 10)//forest pitfall
        {
            player.position = new Vector2(0f, 0f);
            Camera.main.transform.position = new Vector3(0f, 0f, -10f);
        }
        if (levelIndex == 17)//ice mtn lvl 3 to lvl 2 drop
        {
            player.position = new Vector2(26.82f, 56.16f);
            Camera.main.transform.position = new Vector3(0f, 0f, -10f);
        }


    }

}
