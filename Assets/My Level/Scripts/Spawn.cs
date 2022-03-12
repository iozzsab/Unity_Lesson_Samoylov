using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _objectPrefab; 
    [SerializeField] private Vector3[] _spawnPointObject;

    private GameObject _objectClon = null;

    public void Start()
    {
        SpawnObject();
    }
    public void SpawnObject() 
    {
        _objectClon = Instantiate(_objectPrefab, _spawnPointObject[Random.Range(0, _spawnPointObject.Length)], Quaternion.identity);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (_objectClon != null)
            return;
        SpawnObject();
    }
}
