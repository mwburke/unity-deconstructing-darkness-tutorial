using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public float rotateSpeed = 0.1f;
    Vector3 spinSpeed = Vector3.zero;
    Vector3 spinAxis = new Vector3(0, 1, 0);

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }


    // Start is called before  the first frame update
    void Start()
    {

        spinSpeed = new Vector3(Random.value / 10, Random.value / 10, Random.value / 10);

        spinAxis = Vector3.up;
        spinAxis.x = (Random.value - Random.value) * 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);  
    }

}
