using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class Enemy : MonoBehaviour

    {

        [SerializeField] public GameObject _gameObject;
        [SerializeField] public Transform EndPositions;
        [SerializeField] private int _health;

        
        
        public void Hurt(int damage)
        {
            print("Ouch" + damage);

            _health -= damage;
            if (_health <= 0)
            {
                Die();
            }
        }
        private void Die()
        {
            Destroy(_gameObject);

        }
        private void FixedUpdate()
        {
           
           transform.position = Vector3.MoveTowards(transform.position, EndPositions.position, Time.deltaTime);
        }
    }
}

