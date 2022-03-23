using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace StartGameDev
{
    public class PlayerMoveWithMouse : MonoBehaviour
    {

        public RotationAxes axes = RotationAxes.MouseXAndY;
        public float sensHorizontal = 9.0f;
        public float sensVertical = 9.0f;
        public float minVertical = -90.0f;
        public float maxVertical = 90.0f;
        private float _rotationX = 0;
        public float Speed = 5f;
        public bool isGrounded;
        Vector3 m_Movement;
     

         
        
        public enum RotationAxes
        {
            MouseXAndY = 0,
            MouseX = 1,
            MouseY = 2
        }
        private void OnCollisionEnter()
        {
            isGrounded = true;

        }
        void Start()
        {
            Cursor.visible = false;
            Rigidbody body = GetComponent<Rigidbody>();
            if (body != null)
                body.freezeRotation = true;

       
        }
        void Update()
        {
            if (axes == RotationAxes.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);
            }
            else if (axes == RotationAxes.MouseY)
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
                _rotationX = Mathf.Clamp(_rotationX, minVertical, maxVertical);
                float rotationY = transform.localEulerAngles.y;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
            else
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
                _rotationX = Mathf.Clamp(_rotationX, minVertical, maxVertical);
                float delta = Input.GetAxis("Mouse X") * sensHorizontal;
                float rotationY = transform.localEulerAngles.y + delta;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                isGrounded = false;
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
            }
        }
        void FixedUpdate()
        {
            MovementLogic();
        }
        private void MovementLogic()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            m_Movement.Set(moveHorizontal, 0f, moveVertical);
            m_Movement.Normalize();

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.Translate(movement * Speed * Time.fixedDeltaTime);
        }
    }
}