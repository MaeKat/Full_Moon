using UnityEngine;
 
public class World : SceneController {
 
    public Transform player;
 
    // Use this for initialization
    public override void Start () {
        base.Start();
 
        if (prevScene == "Mountain_Pass" && currentScene == "Mountain_Pass_Pitfall_1") {
            player.position = new Vector2(.17f, 15.37f);
            Camera.main.transform.position = new Vector3(-35.5f, 13.91f, -10f);
      
            
        }
        if (prevScene == "Mountain_Pass" && currentScene == "Mountain_Pass_Pitfall_2") {
            player.position = new Vector2(-31.15f, -25.8f);
            Camera.main.transform.position = new Vector3(-35.5f, 13.91f, -10f);    
        }        
        if (prevScene == "Mountain_Pass_Pitfall_1") {
            player.position = new Vector2(-36.03f, -12.59f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }
         if (prevScene == "Mountain_Pass_Pitfall_2") {
                 player.position = new Vector2(-52.37f, -15.2f);
            Camera.main.transform.position = new Vector3(-31.5f, -25.91f, -10f);
        }

    }
     
}