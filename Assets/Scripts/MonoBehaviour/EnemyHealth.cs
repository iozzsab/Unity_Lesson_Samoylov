using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace StartGameDev
{
    public class EnemyHealth : MonoBehaviour

    {
        //private Rigidbody _rb;
        
        //private NavMeshAgent agent;
        //[SerializeField] private GameObject _gameObject;
        [SerializeField] private int _health = 100;
        
        
        public void Hurt(int damage)

        {
            print("Получено урона: " + damage);

            _health -= damage;
            if (_health <= 0)
            {
                Die();
            }
            
        }
        private void Die()
        {
            //_rb = GetComponent<Rigidbody>();
            //_rb.constraints = RigidbodyConstraints.None | RigidbodyConstraints.None | RigidbodyConstraints.None;
            //gameObject.GetComponent<NavMesh>().enabled = false;
            //gameObject.GetComponent<EnemyShoot>().enabled = false;
            //gameObject.GetComponent<NavMeshAgent>().enabled = false;
           // gameObject.GetComponent<EnemyVision>().enabled = false;
           
            
            Destroy(gameObject);

        }
        
    }
}


