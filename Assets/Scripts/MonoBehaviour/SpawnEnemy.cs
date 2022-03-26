using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _Enemy;
    [SerializeField] private Transform _EnemySpawnPosition;


    public void Start()
    {
        SpawnObject();
    }
    public void SpawnObject()
    {
        Instantiate(_Enemy, _EnemySpawnPosition.position, _EnemySpawnPosition.rotation);
    }


    private void Update()
    {

        if (_Enemy != null)
            return;
        SpawnObject();
    }
}
        /*


         public void Start()
         {
             SpawnObject();
         }
         public void SpawnObject()
         {
             Instantiate(_Enemy, _EnemySpawnPosition.position, _EnemySpawnPosition.rotation);
         }


        private void Update()
         {

             if (_Enemy != null)
                 return;
             SpawnObject();
         }
        */

    
