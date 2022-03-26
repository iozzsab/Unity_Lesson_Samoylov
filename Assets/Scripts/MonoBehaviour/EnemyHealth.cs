using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class EnemyHealth : MonoBehaviour

    {

        [SerializeField] public GameObject _gameObject;
        

        [SerializeField] public int _health = 100;
        
        
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
        
    }
}

