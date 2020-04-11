﻿using UnityEngine;
public class ChangeScene : MonoBehaviour {
    [SerializeField] private string toScene;
    private SceneController sceneController;
    void Start() {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            sceneController.LoadScene(toScene);
        }
    }
}