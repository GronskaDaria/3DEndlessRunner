using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    void Start()
    {

    }

    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal")*movementSpeed/2;
        float vMovement = Input.GetAxis("Vertical")*movementSpeed;

        transform.Translate(new Vector3(hMovement, 0, vMovement)*Time.deltaTime);


    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
