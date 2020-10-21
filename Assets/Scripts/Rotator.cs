using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 offset = new Vector3(0,0,0);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(offset * Time.deltaTime);
    }
}
