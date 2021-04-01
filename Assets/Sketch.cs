using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{

    public GameObject myPrefab;
    public int cubeCount;
    public float minDist = 5.0f;
    public float maxDist = 50.0f;
    public float maxSize = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        cubeCount = Random.Range(5, 10);

        for (int i = 0; i < cubeCount; i++)
        {
            float pct = i / (float)cubeCount;

            float dist = minDist + (maxDist - minDist) * pct; // Random.Range(minDist, maxDist);
            float distPct = dist / (maxDist - minDist);
            
            float x = Mathf.Cos(pct * 360f) * dist;
            float y = 5.0f;  
            float z = Mathf.Sin(pct * 360f) * dist;
            // float size = maxSize * Mathf.Sin((maxDist - dist) / maxDist * Mathf.PI/2f);
            float size = maxSize * (1f - pct);

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<CubeScript>().SetSize(size);
            newCube.GetComponent<CubeScript>().rotateSpeed = pct / 5f;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
