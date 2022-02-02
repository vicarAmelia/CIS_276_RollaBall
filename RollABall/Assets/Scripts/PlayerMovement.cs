using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
        private Vector3 moveInput;
        public Rigidbody rb;
        private PlayerCamera playerCam;
        private float speed = 4f;
        private float jumpForce = 3f;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            playerCam = FindObjectOfType<PlayerCamera>();
        }
}

private void FixedUpdate()
{
   MovePlayer(); 
}

private void Update()
{
    moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))

    if(Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
    }

private void MovePlayer()
{
    rb.velocity = new Vector3(moveInput.x * speed, rb.velocity.y, moveInput.z * speed);
}
}