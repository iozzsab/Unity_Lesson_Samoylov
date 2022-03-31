using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
{
    public class FinishGame : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            
            Debug.Log("Конец игры!");
        }
    }
}
