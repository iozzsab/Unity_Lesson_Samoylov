using UnityEngine;
using UnityEngine.UI;

namespace StartGameDev
{
        public class Explosion : MonoBehaviour
    {
        public float radius = 5.0f;
        public float power = 10.0f;
        public GameObject Light;

        void Start()
        {
            Destroy(Light, 0.1f);

            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);

            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(power, explosionPos, radius, 3.0f);
                }
            }
        }
    }
}

