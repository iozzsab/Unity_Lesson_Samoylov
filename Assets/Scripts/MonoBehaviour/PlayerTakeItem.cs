using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class PlayerTakeItem : MonoBehaviour
    {
        [SerializeField] private int takePower;
        [SerializeField] private int dropPower;

        [SerializeField] private float rayDistance;
        private bool Take = false;
        private bool Drop = false;
        Transform offset;
        RaycastHit hit;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Physics.Raycast(transform.position, transform.forward, out hit, rayDistance);
                if (hit.rigidbody)
                {
                    Take = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (Take)
                {
                    Take = false;
                    Drop = true;
                }
            }
            if (Take)
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.velocity = (offset.position - (hit.transform.position + hit.rigidbody.centerOfMass));
                }
            }
            if (Drop)
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.velocity = transform.forward * dropPower;
                    Drop = false;
                }
            }
        }
    }
}
