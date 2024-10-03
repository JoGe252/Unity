using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed = 1000;
    // Start is called before the first frame update
    void start()
    {
        
    }

    // Update is called once per frame
    void update()
    {
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}

