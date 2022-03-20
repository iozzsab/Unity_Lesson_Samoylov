using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReactOnEnter : ITriggegByTag
{
    [SerializeField] private List<Condition> satisfied_conditions;
    [SerializeField] private List<Condition> unsatisfied_conditions;
    [SerializeField] private List<IReaction> reactions;

    protected override void OnTriggerEnterWithTag(Collider other)
    {
        foreach (var condition in satisfied_conditions)
        {
            if (!condition.isSatisfied) return;
        }
        foreach (var condition in unsatisfied_conditions)
        {
            if (condition.isSatisfied) return;
        }
        foreach (var reaction in reactions)
        {
            reaction.React();
        }
    }
    
}
