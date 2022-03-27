using UnityEngine;
using UnityEngine.UI;

namespace StartGameDev
{
    public class MineExplosion : MonoBehaviour
    {
        [SerializeField] public GameObject minePrefab;
        [SerializeField] public float radius = 10.0F;
        [SerializeField] public float power = 20.0F;
        [SerializeField] public int _damage;

        private void Update()
        {
            Ray ray = new Ray(transform.position, transform.forward);
        }

        private void OnTriggerEnter(Collider other)

        {
            Ray ray = new Ray (transform.position, transform.forward);
            if (other.CompareTag("Enemy"))
            {
                if (Physics.Raycast(ray, out RaycastHit hit, 10))
                {
                    Collider[] collider = Physics.OverlapSphere(hit.point, radius);
                    var enemy = other.GetComponent<EnemyHealth>();
                    enemy.Hurt(_damage);
                    foreach (var col in collider)
                    {
                        if (col.GetComponent<Rigidbody>())
                        {
                            col.GetComponent<Rigidbody>().AddForce(-(hit.point - col.transform.position) * power);
                            Destroy(gameObject);
                        }
                    }
                }
            }
        }
       

    }
}
/*
 * [SerializeField] private int _damage;
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.CompareTag("Enemy"))
            {
                var enemy = collider.GetComponent<Enemy>();
                enemy.Hurt(_damage);
 * */