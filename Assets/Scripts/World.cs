using UnityEngine;
 
public class World : SceneController {
 
    public Transform player;
 
    // Use this for initialization
    public override void Start () {
        base.Start();
 
        if (prevScene == "Mountain_Pass") {
            player.position = new Vector2(0f, 3f);
            Camera.main.transform.position = new Vector3(0f, 3f, -10f);
        }
    }
     
}