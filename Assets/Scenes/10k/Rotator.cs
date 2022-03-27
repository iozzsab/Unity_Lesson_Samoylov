using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    private void Update()
    {
        Rotarions();
        

    }
    public void Rotarions()
    {
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        

    }
}
