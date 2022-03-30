using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransformReaction : IReaction
{
    [SerializeField] private Vector3 end_target_position;
    
    //[SerializeField] private Vector3 start_target_position;
    // public float speed;


    public override void React()
    {
        transform.position = end_target_position;
    }
    //transform.position = Vector3.MoveTowards(transform.position, end_target_position, speed * Time.deltaTime);
    //transform.position = Vector3.(transform.position, end_target_position, Time.deltaTime);

    private void Update()
    {
        


    }
}

