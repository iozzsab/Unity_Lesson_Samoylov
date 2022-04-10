using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
namespace StartGameDev
{
    public class Grenade : MonoBehaviour
    {
        public Transform _explosionPrefab;
        [SerializeField] public int damage;
        

        void OnCollisionEnter(Collision collision)
        {
            ContactPoint contact = collision.contacts[0];

            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            Instantiate(_explosionPrefab, pos, rot);
            Destroy(gameObject);

        }
        private void OnTriggerEnter(Collider other)
        {
            Ray ray = new Ray(transform.position, transform.forward);
            if (other.CompareTag("Enemy"))
            {
                if (Physics.Raycast(ray, out RaycastHit hit, 10))
                {
                    var enemy = other.GetComponent<EnemyHealth>();

                    enemy.Hurt(damage);
                }
            }
        }
        
    }
}
