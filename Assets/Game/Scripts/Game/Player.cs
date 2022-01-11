using UnityEngine;

public class Player : MonoBehaviour
{
    // Player Main variables

    // player accelaration
    [Header("Player Speed")]
    [SerializeField] private float FORWARD_ACCELERATION = 14.0f;
    //
    private const float BACKWARD_ACCELERATION = 10.0f;
    //
    private const float STRAFE_ACCELERATION = 10.0f;
    // Jump speed
    [Header("Player Jump Speed")]
    [SerializeField] private float JUMP_ACCELERATION = 300.0f;
    // Gravity speed
    private const float GRAVITY_ACCELERATION = 10.0f;
    // Maximum Speeds

    // [SerializeField] 
    private const float MAX_FORWARD_VELOCITY = 6.0f;

    //
    private const float MAX_BACKWARD_VELOCITY = 2.0f;
    
    // [SerializeField] 
    private const float MAX_STRAFE_VELOCITY = 5.0f;

    // 
    private const float MAX_JUMP_VELOCITY = 50.0f;
    //
    private const float MAX_FALL_VELOCITY = 100.0f;
    // 
    private const float ROTATION_VELOCITY_FACTOR = 2.0f;
    //
    private const float MIN_TILT_ROTATION = 70.0f;
    //
    private const float MAX_TILT_ROTATION = 290.0f;
    //
    private CharacterController _controller;
    //
    private Transform _cameraTransform;
    //
    private Vector3 _acceleration;
    //
    private Vector3 _velocity;
    //
    private bool _jump;

    // Camera reference for Object interaction
    


    //
    void Start()
    {
        _controller      = GetComponent<CharacterController>();
        _cameraTransform = GetComponentInChildren<Camera>().transform;
        _acceleration    = Vector3.zero;
        _velocity        = Vector3.zero;
        _jump            = false;

        
        
        
    }

    // this method hides the cursor on the game screen
    public void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShowCursor()
    {
        Cursor.visible = true;
    }

    // Jump Method
    void Update()
    {
        UpdateJump();
        UpdateRotation();
        UpdateTilt();

       
    }

    // Update jump
    private void UpdateJump()
    {
        if (Input.GetButtonDown("Jump") && _controller.isGrounded)
            _jump = true;
    }

    // rotation update
    private void UpdateRotation()
    {
        float rotation = Input.GetAxis("Mouse_X") * ROTATION_VELOCITY_FACTOR;

        transform.Rotate(0f, rotation, 0f);
    }

    // tilt update
    private void UpdateTilt()
    {
        Vector3 cameraRotation = _cameraTransform.localEulerAngles;

        cameraRotation.x -= Input.GetAxis("Mouse_Y") * ROTATION_VELOCITY_FACTOR;

        if (cameraRotation.x < 180f)
            cameraRotation.x = Mathf.Min(cameraRotation.x, MIN_TILT_ROTATION);
        else
            cameraRotation.x = Mathf.Max(cameraRotation.x, MAX_TILT_ROTATION);

        _cameraTransform.localEulerAngles = cameraRotation;
    }

    // 
    void FixedUpdate()
    {
        UpdateAcceleration();
        UpdateVelocity();
        UpdatePosition();

        if (PauseMenu.Paused)
        {
            ShowCursor();
        }
        else
        {
            HideCursor();
        }
    }

    //
    private void UpdateAcceleration()
    {
        _acceleration.z = Input.GetAxis("Forward");
        _acceleration.z *= (_acceleration.z > 0f) ? FORWARD_ACCELERATION : BACKWARD_ACCELERATION;

        _acceleration.x = Input.GetAxis("Strafe") * STRAFE_ACCELERATION;

        if (_jump)
        {
            _acceleration.y = JUMP_ACCELERATION;
            _jump = false;
        }
        else if (_controller.isGrounded)
            _acceleration.y = 0f;
        else
            _acceleration.y = -GRAVITY_ACCELERATION;
    }

    //
    private void UpdateVelocity()
    {
        _velocity += _acceleration * Time.fixedDeltaTime;

        _velocity.z = (_acceleration.z == 0f || _acceleration.z * _velocity.z < 0f) ?
            0f : Mathf.Clamp(_velocity.z, -MAX_BACKWARD_VELOCITY, MAX_FORWARD_VELOCITY);
        
        _velocity.x = (_acceleration.x == 0f || _acceleration.x * _velocity.x < 0f) ?
            0f : Mathf.Clamp(_velocity.x, -MAX_STRAFE_VELOCITY, MAX_STRAFE_VELOCITY);

        _velocity.y = (_acceleration.y == 0f) ?
            -0.1f : Mathf.Clamp(_velocity.y, -MAX_FALL_VELOCITY, MAX_JUMP_VELOCITY);
    }

    //
    private void UpdatePosition()
    {
        Vector3 motion = _velocity * Time.fixedDeltaTime;

        _controller.Move(transform.TransformVector(motion));
    }

    //
}
