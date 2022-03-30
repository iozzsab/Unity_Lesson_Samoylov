using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class GreenKey : MonoBehaviour
    {
        // Start is called before the first frame update
        public void Update()
        {
            Rotator();
        }

        public void Rotator()
        {

            transform.Rotate(Vector3.up * Time.deltaTime * 100f, Space.World);
        }
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.CompareTag("Player"))
            {

                var player = other.GetComponent<HPPlayer>();
                Destroy(gameObject);
            }
        }
    }
}