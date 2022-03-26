using UnityEngine;

namespace StartGameDev
{
    public class Bomb : MonoBehaviour
    {
        public GameObject BombObject;
        public float radius = 10.0F;
        public float power = 20.0F;

        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Enemy")
            {
                Vector3 explosionPos = transform.position;
                Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
                foreach (Collider hit in colliders)
                {
                    Rigidbody rb = hit.GetComponent<Rigidbody>();

                    if (rb != null)
                        rb.AddExplosionForce(power, explosionPos, radius, 3.0F);

                    Debug.Log("вот он бах");
                    Destroy(BombObject);
                    Destroy(gameObject);

                }
            }
        }
    }
}
    




/*


    public class Bomb : MonoBehaviour
    {
        [SerializeField] private int _damage;
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.CompareTag("Enemy"))
            {
                var enemy = collider.GetComponent<Enemy>();
                enemy.Hurt(_damage);
                
            }
        }

    }

*/