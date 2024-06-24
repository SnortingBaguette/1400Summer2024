using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]private float moveSpeed;
    [SerializeField]private float jumpForce;
    [SerializeField]private float gravity;
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController()>;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
