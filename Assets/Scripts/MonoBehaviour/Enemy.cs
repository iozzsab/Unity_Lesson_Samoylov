using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class Enemy : MonoBehaviour

    {

        public GameObject _gameObject;
        public Transform EndPositions;
        [SerializeField] public int _health;

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
        private void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, EndPositions.position, Time.deltaTime);
        }
    }
}

