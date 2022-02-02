using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
   [SerializeField] private GameObject player;
   private Vector3 cameraOffset;

   private void Awake()
   {
       player = FindObjectOfType<PlayerMovement>().gameObject;
   }

   void Start()
   {
     cameraOffset = transform.position - player.transform.position;  
   }

   void Update()
   {
       transform.position = cameraOffset + player.transform.position;
   }
}
