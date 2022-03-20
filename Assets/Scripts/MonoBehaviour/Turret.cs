using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class Turret : MonoBehaviour
    {
        [SerializeField] public PlayerMoveWithMouse _player;
        [SerializeField] private float _speedRotate;

        [SerializeField] private Transform _bulletSpawnPosition;
        [SerializeField] private GameObject _bulletPrefab;

        void Start()
        {
            _player = FindObjectOfType<PlayerMoveWithMouse>();

        }

        void FixedUpdate()
        {
            if (Vector3.Distance(transform.position, _player.transform.position) < 4)
            {
                var direction = _player.transform.position - transform.position;

                var stepRotate = Vector3.RotateTowards(transform.forward, direction, _speedRotate * Time.fixedDeltaTime, 0f);

                transform.rotation = Quaternion.LookRotation(stepRotate);
            }
        }
        private void Update()
        {
            if (Vector3.Distance(transform.position, _player.transform.position) < 4)
            {
                
                    Fire();
            }
        }
        private void Fire()
        {
            var bulletObj = Instantiate(_bulletPrefab, _bulletSpawnPosition.position, _bulletSpawnPosition.rotation);
            var bullet = bulletObj.GetComponent<Bullet>();
            bullet.Init(_player.transform, 7, 1);//Transform target, float lifeTime, float speed)
        
        }
    }
}
