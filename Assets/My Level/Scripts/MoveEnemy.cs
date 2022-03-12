using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Transform EndPosition;

    private void Start()
    {
        
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, EndPosition.position, Time.deltaTime);
    }


}
