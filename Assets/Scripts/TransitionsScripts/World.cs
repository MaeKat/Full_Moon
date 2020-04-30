using UnityEngine;
 
public class World : SceneController {
 
    public Transform player;
 
    // Use this for initialization
    public override void Start () {
        base.Start();
 //Hometown 
        if (prevScene == "Hometown" && currentScene == "Inside_Houses") {//up ladder from pit 2 to mt pass
            player.position = new Vector2(-1.39f, -4.31f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }
        if (prevScene == "Inside_Houses" && currentScene == "Hometown") {//up ladder from pit 2 to mt pass
            player.position = new Vector2(-28.48f, 3.98f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }

//Forest       
        if (prevScene == "Forest" && currentScene == "Forest_Pitfall_Scene") {
            player.position = new Vector2(4.19f, 3.16f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }
        if (prevScene == "Forest_Pitfall_Scene" && currentScene == "Forest") {
            player.position = new Vector2(-84.5f, 65.0f);
            Camera.main.transform.position = new Vector3(-84.66f, 25.91f, -10f);
        }    
         if (prevScene == "Forest_Cabin" && currentScene == "Forest_Pitfall_Scene") {
            player.position = new Vector2(3.11f, 42.89f);
            Camera.main.transform.position = new Vector3(-31.5f, 65.21f, -10f);
        }       



 //Mountain Pass
        if (prevScene == "Mountain_Pass" && currentScene == "Mountain_Pass_Pitfall_1") {//down ladder for pit 1
            player.position = new Vector2(.17f, 15.37f);
            Camera.main.transform.position = new Vector3(-35.5f, 13.91f, -10f);       
        }
        if (prevScene == "Mountain_Pass" && currentScene == "Mountain_Pass_Pitfall_2") { //down ladder for pit 2
            player.position = new Vector2(-31.15f, -25.8f);
            Camera.main.transform.position = new Vector3(-35.5f, 13.91f, -10f);
        }        
        if (prevScene == "Mountain_Pass_Pitfall_1"  && currentScene == "Mountain_Pass") { //up ladder form pit 1 to mt pass
            player.position = new Vector2(-36.03f, 12.59f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }
         if (prevScene == "Mountain_Pass_Pitfall_2" && currentScene == "Mountain_Pass") {//up ladder from pit 2 to mt pass
                 player.position = new Vector2(-52.37f, -15.2f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }

    }
     
}