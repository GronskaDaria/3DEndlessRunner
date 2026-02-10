using UnityEngine;

public class TestCameraController : MonoBehaviour
{

    private Transform player;
    
    private float yOffset=2f;
    private float zOffset=-3.5f;
   
    void Start()
    {
        player=GameObject.Find("Player").transform;
        
    }

    void LateUpdate()
    {
        transform.position=new Vector3(player.position.x, player.position.y+yOffset, player.position.z+zOffset);
    }
}
