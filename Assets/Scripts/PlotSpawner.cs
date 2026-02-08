using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 5;
    private float initStartZ=10f;
    private float plotSize = 40f;
    private float xPosLeft=-39f;
    private float xPosRight=39f;
    private float lastZPos=0;

    public List<GameObject> plots;


    void Start()
    {
        SpawnPlot();
        
    }

    void Update()
    {
        
    }

    public void SpawnPlot()
    {
        for (int i = 0; i<initAmount; i++)
        {
            GameObject plotLeft = plots [Random.Range(0, plots.Count)];
            GameObject plotRight = plots [Random.Range(0, plots.Count)];

            float zPos = lastZPos+initStartZ;

            Instantiate(plotLeft, new Vector3(xPosLeft, 0.22f, zPos), plotLeft.transform.rotation);
            Instantiate(plotRight, new Vector3(xPosRight, 0.22f, zPos), new Quaternion(0, 180, 0, 0));

            lastZPos+=plotSize;

        }
    }
}
