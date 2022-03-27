using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartGameDev
    {
    public class MineSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject _PlayerMine;

        
        void Start()
        {

        }

        
        void Update()
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, 100))
            {
                

                if (Input.GetKeyDown(KeyCode.F))
                {
                    GameObject go = Instantiate(_PlayerMine, transform.position + Vector3.Normalize(hitInfo.point - transform.position), transform.rotation);
                    Rigidbody rig = go.GetComponent<Rigidbody>();
                    rig.velocity = Vector3.Normalize(hitInfo.point - transform.position) * 2;

                }
            }

        }
    }
}
