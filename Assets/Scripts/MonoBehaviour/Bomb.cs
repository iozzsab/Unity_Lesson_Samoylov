using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class Bomb : MonoBehaviour
    {
        [SerializeField] private int _damage;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                var enemy = other.GetComponent<Enemy>();
                enemy.Hurt(_damage);
                Destroy(gameObject);
            }
        }

    }
}
