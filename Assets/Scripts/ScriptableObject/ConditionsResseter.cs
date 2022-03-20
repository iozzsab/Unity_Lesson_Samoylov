using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsResseter : MonoBehaviour
{
    private void Awake()
    {
        var conditions = Resources.FindObjectsOfTypeAll<Condition>();
        foreach (Condition c in conditions)
        {
            c.Reset();
        }
    }
}
