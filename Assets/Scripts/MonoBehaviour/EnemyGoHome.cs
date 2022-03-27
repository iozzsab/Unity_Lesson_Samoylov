using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace StartGameDev
{
    public class EnemyGoHome : MonoBehaviour
    {
        [SerializeField] Transform _homePossition;
       // [SerializeField] GameObject _Enemy;
        private NavMeshAgent navMesh;

        void Start()
        {
            navMesh = GetComponent<NavMeshAgent>();

        }

       
        void FixedUpdate()
        {
            if (navMesh.enabled == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, _homePossition.position, Time.deltaTime);
            }

        }
    }
}
