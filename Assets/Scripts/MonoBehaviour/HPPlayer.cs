using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StartGameDev
{
    public class HPPlayer : MonoBehaviour
    {


        [SerializeField] public int _HP;
        public Text hpText;


        void Start()
        {
            hpText.text = "Health: " + _HP.ToString();
        }
        public void HPBoosted(int HPBoost)
        {
            print("Tasty" + HPBoost);

            _HP = _HP + HPBoost;

            if (_HP > 150)
            {
                _HP = 150;
            }
            hpText.text = "Health: " + _HP.ToString();

            if (_HP <= 0)
            {
                Destroy(gameObject);
            }
            

        }
        private void Die()
        {
            Destroy(gameObject);
        }
        private void Update()
        {
            
           
        }
    }
}



