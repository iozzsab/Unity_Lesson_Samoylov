using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class Gun : MonoBehaviour
    {
        //[SerializeField] private float damage;
        [SerializeField] private float range;
        //[SerializeField] private float fireRate;
        [SerializeField] private float force;
        [SerializeField] private ParticleSystem shotBullet;
        [SerializeField] private Transform bulletSpawn;
        [SerializeField] private Camera _cam;
        //[SerializeField] private GameObject _bulletPrefab;
        void Start()
        {

        }
               
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
            
        }
        void Shoot()
        {
            //Instantiate(shotBullet, bulletSpawn.position, bulletSpawn.rotation);
            
            
            RaycastHit hit;
           if (Physics.Raycast(bulletSpawn.transform.position, _cam.transform.forward, out hit, range))
            {
                Debug.Log("Выстрел", hit.collider);
            }
            shotBullet.Play();
            
            
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal * force);
            }
            //var bulletObj = Instantiate(_bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            //var bullet = bulletObj.GetComponent<Bullet>();
            
        }
    }
}
