using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class EnemyShoot : MonoBehaviour
    {
        [SerializeField] private PlayerMoveWithMouse _player;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _bulletSpawnPosition;
        [SerializeField] private float _cooldown;
        [SerializeField] private bool _isFire;

        // Start is called before the first frame update
        void Start()
        {
            _player = FindObjectOfType<PlayerMoveWithMouse>();

        }

        // Update is called once per frame
        void Update()
        {
            if (Vector3.Distance(transform.position, _player.transform.position) < 4)
            {
                if (_isFire)
                    Fire();
            }
        }
        private void Fire()
        {
        _isFire = false;
            var bulletObj = Instantiate(_bulletPrefab, _bulletSpawnPosition.position, _bulletSpawnPosition.rotation);
            var bullet = bulletObj.GetComponent<Bullet>();
            bullet.Init(_player.transform, 10, 0.5f);//Transform target, float lifeTime, float speed

            Invoke(nameof(Reloading), _cooldown);
        }
        private void Reloading()
        {
        _isFire=true;
        }
    }
}
