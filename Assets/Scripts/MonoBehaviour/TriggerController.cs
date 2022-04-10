using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class TriggerController : MonoBehaviour
    {
        [SerializeField] private AudioReverbZone aRvbZone;
        

        
        private void OnTrrigerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                aRvbZone.enabled = true;
            



        }

        private void OnTrrigerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                aRvbZone.enabled = false;
            
        }

    }
}
