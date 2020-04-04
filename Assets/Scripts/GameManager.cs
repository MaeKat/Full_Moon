using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Menu() {
        SceneManager.LoadScene("MainMenu");
    }  
    
    //add a restart button
    public void Restart() {
        SceneManager.LoadScene("Hometown");
    }
}
