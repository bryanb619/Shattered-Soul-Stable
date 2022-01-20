using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Speed")]
    [SerializeField] private float walkingSpeed = 5.0f;
    [Header("Player Sprint Speed")]
    [SerializeField] private float runningSpeed = 8.5f;
    [Header("Player Jump Speed")]
    [SerializeField] private float jumpSpeed = 6.0f;
    [Header("Player Gravity")]
    [SerializeField] private float gravity = 20.0f;
    [Header("Player Camera")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float lookSpeed = 2.0f;
    [SerializeField] private float lookXLimit = 45.0f;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    [HideInInspector]
    public bool canMove = true;

    bool IsMoving = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        

        // Lock cursor
        HideCursor();
    }

    void Update()
    {
        // We are grounded, so recalculate move direction based on axes
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        // Left Shift to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Forward") : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Strafe") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;

        }

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Player and Camera rotation
        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse_Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse_X") * lookSpeed, 0);
        }
        /* if (Input.GetKeyDown(KeyCode.C))
        {
            playerCamera.transform.position = Vector3.Lerp(playerCamera.transform.position, crouchPosition.position, Time.deltaTime * smooth);
            check = true;
        }
        else
        {
            if (check == true)
            {
                playerCamera.transform.position = Vector3.Lerp(playerCamera.transform.position, playerCamera.position, Time.deltaTime * smooth);
                check = false;
            }
        }
        */
    }
    private void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}