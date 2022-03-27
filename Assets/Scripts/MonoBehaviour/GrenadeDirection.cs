using UnityEngine;
using UnityEngine.UI;


namespace StartGameDev
{
    public class GrenadeDirection : MonoBehaviour
    {
        [SerializeField] private Text _distanceTx;
        [SerializeField] private float _distanceValue;
        [SerializeField] private GameObject _grenadePrefab;

       
        
         
        void Update()
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, 230))
            {
                _distanceValue = hitInfo.distance;
                _distanceTx.text = _distanceValue.ToString();

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    GameObject go = Instantiate(_grenadePrefab, transform.position + Vector3.Normalize(hitInfo.point - transform.position), transform.rotation);
                    Rigidbody rig = go.GetComponent<Rigidbody>();
                    rig.velocity = Vector3.Normalize(hitInfo.point - transform.position) * 10;
                    
                }
            }
           
        }
    }
}
