using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upper2Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.1f, -0.1f, 0);
        //transform.Rotate(1.5f, 1.5f, 1.5f);
        transform.position = new Vector3(-2 * Mathf.Sin(Time.time), 2 * Mathf.Cos(Time.time), -2 * Mathf.Cos(Time.time));

    }
}
