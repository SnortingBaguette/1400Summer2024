using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]private float moveSpeed = 5f;
    [SerializeField]private float jumpForce = 5f;
    [SerializeField]private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping = false;

    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical") * moveSpeed;
        horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
        moveDirection.x = horizontalInput;
        moveDirection.z = verticalInput;
        moveDirection.y = moveDirection.y - gravity * Time.deltaTime;

        if (Input.GetButton("Jump") && !isJumping)
        {
            StartCoroutine(JumpCooldown());
            moveDirection.y = jumpForce;
            isJumping = true;
        }


        controller.Move(moveDirection * Time.deltaTime);
        Debug.Log(verticalInput);
    }

    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(1);
        isJumping = false;
        moveDirection.y = 0;
    }
}
