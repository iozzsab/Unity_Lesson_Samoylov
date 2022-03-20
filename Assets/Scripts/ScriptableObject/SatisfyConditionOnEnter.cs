using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatisfyConditionOnEnter : ITriggegByTag
{    
    [SerializeField] private Condition condition;

    protected override void OnTriggerEnterWithTag(Collider other)
    {
        condition.Satisfy();
    }
}
