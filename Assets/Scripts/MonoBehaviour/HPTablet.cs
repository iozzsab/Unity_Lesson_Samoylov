using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StartGameDev
{
    public class HPTablet : MonoBehaviour

    {
        [SerializeField] private int HPBoost;
        
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.CompareTag("Player"))
            {
                
                var player = other.GetComponent<HPPlayer>();
                player.HPBoosted(HPBoost);
                
                Destroy(gameObject);
            }
            
        }

        /*
        
        public int hPoint;
        public Text hpText;
        public int hpDamage;
        public int takeHP;

        
         void Start()
         {
             hpText.text = "Health: " + hPoint.ToString();
         }

         private void OnTroggerEnter(Collision other)
         {
             if (other.gameObject.tag == "bullet")

             {
                 hPoint = hPoint - hpDamage;
                 hpText.text = "Health: " + hPoint.ToString();

             }
             if (hPoint <= 0)
             {
                 Destroy(gameObject);
                 hpText.text = "Health: 0";
             }


             if (other.gameObject.tag == "HeatPoint")

             {
                 hPoint = hPoint + takeHP;
                 hpText.text = "Health: " + hPoint.ToString();
             }
         }
         
       

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                var player = other.GetComponent<PlayerMoveWithMouse>();
                hPoint = hPoint + takeHP;
                hpText.text = "Health: " + hPoint.ToString();
            }
        }
        */



    }
}
