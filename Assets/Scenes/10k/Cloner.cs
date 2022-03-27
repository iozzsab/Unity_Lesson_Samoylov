using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class Cloner : MonoBehaviour
    {

        public GameObject _createEmpt;


        void Start()
        {
            for (int i = 0; i < 10000; i++)
            {
                
                Instantiate(_createEmpt, new Vector3(RandonNumber(), RandonNumber(), RandonNumber()), Quaternion.Euler(RandonNumber(), -10f, 40f));
            }

        }
        private int RandonNumber()
        {
            return Random.Range(0, 50);
        }
    }
}
