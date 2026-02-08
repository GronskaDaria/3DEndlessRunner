using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    PlotSpawner plotSpawner;
    void Start()
    {
        roadSpawner= gameObject.GetComponent<RoadSpawner>();
        plotSpawner=gameObject.GetComponent<PlotSpawner>();

    }

    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
    }
    
}
