using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class BoostJump : MonoBehaviour
    {
        [SerializeField] private int JBoost;
        

        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.CompareTag("Player"))
            {

                var player = other.GetComponent<PlayerMoveWithMouse>();
                player.JumpBoosted(JBoost);

                Destroy(gameObject);
            }

        }
              
    }
}