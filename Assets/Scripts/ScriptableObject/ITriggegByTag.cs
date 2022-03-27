using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class ITriggegByTag : MonoBehaviour
{
    [SerializeField] private List<string> tags;

    private void Awake()
    {
        foreach (var collider in GetComponents<Collider>())
        {
            if (collider.isTrigger) return;
        }
        Debug.LogWarning($"Нет триггера в объекте {name}, условие не будет удовлетворено!");
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var s in tags)
        {
            if (other.tag == s)
            {
                OnTriggerEnterWithTag(other);
                return;
            }
        }
    }
    protected abstract void OnTriggerEnterWithTag(Collider other);
}
        
    
   