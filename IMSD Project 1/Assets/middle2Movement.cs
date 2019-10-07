using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle2Movement : MonoBehaviour
{
    GameObject Circle;
    // Start is called before the first frame update
    void Start()
    {
        Circle = GameObject.Find("CenterPoint");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(2 * Mathf.Sin(Time.time), 2 * Mathf.Cos(Time.time), 0);
        transform.Translate(0.1f,0, 0);
        transform.Rotate(Circle.transform.up);



    }
}
