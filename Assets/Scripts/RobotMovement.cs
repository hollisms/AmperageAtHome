using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RobotMovement : MonoBehaviour
{
    PlayerControls controls;
    Vector2 moveLeft;
    Vector2 moveRight;
    Text txtConeCounter;
    int coneCounter = 0;
    public Rigidbody rbRobot;
    private Rigidbody rbLeftMotor;
    private Rigidbody rbRightMotor;


    public float coAcceleration = 500.0f;
    public float smooth = 5.0f;
    public float maxVelocity = 2.0f;
    public float joystickDeadzone = 0.05f;
    public int driveType = 0;

    void Start()
    {
        rbLeftMotor = GameObject.Find("LeftMotor").GetComponent<Rigidbody>();
        rbRightMotor = GameObject.Find("RightMotor").GetComponent<Rigidbody>();
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.MoveLeft.performed += ctx => moveLeft = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveLeft.canceled += ctx => moveLeft = Vector2.zero;

        controls.Gameplay.MoveRight.performed += ctx => moveRight = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveRight.canceled += ctx => moveRight = Vector2.zero;

        controls.Gameplay.RestartLevel.performed += ctx => RestartLevel();

        // TODO should probably be in Start
        txtConeCounter = GameObject.Find("txtConeCounter").GetComponent<Text>();
        txtConeCounter.text = coneCounter.ToString();
        rbRobot.centerOfMass = Vector3.zero;
    }

    void FixedUpdate()
    {

        // implement deadzone
        if (Mathf.Abs(moveLeft.y) < joystickDeadzone)
        {
            moveLeft.y = 0;
        }
        if (Mathf.Abs(moveRight.x) < joystickDeadzone)
        {
            moveLeft.x = 0;
        }

        switch (driveType)
        {
            case 1:
                FixedUpdateTankDrive();
                break;
            default:
                FixedUpdateArcadeDrive();
                break;
        }
    }


    void FixedUpdateTankDrive()
    {
        // calculate left & right side forces
        Vector3 fL = new Vector3(0, 0, moveLeft.y * coAcceleration / 2) * Time.deltaTime;
        Vector3 fR = new Vector3(0, 0, moveRight.y * coAcceleration / 2) * Time.deltaTime;

        // apply forces
        rbLeftMotor.AddForce(transform.rotation * (fL));
        rbRightMotor.AddForce(transform.rotation * (fR));

        // debug code
        if (!Debug.isDebugBuild) return;

        // show unit vector for direction + unit vector for % of max force
        Vector3 fLDebug = new Vector3(0, 0, moveLeft.y + 1.0f);
        if (moveLeft.y < 0) fLDebug.z -= 2.0f;

        Vector3 fRDebug = new Vector3(0, 0, moveRight.y + 1.0f);
        if (moveRight.y < 0) fRDebug.z -= 2.0f;

        Vector3 forward = transform.TransformDirection(fLDebug);
        Debug.DrawRay(rbLeftMotor.position, forward);


        forward = transform.TransformDirection(fRDebug);
        Debug.DrawRay(rbRightMotor.position, forward);




    }

    void FixedUpdateArcadeDrive()
    {
        // calculate a vector to add the force from the motors
        // and rotate the robot
        Vector3 m = new Vector3(0, 0, moveLeft.y * coAcceleration) * Time.deltaTime;
        Quaternion q = Quaternion.Euler(0, moveRight.x * 30.0f, 0) * transform.rotation;

        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * smooth);
        rbRobot.AddForce(transform.rotation * m);

        // cap the maximum velocity
        if (rbRobot.velocity.magnitude > maxVelocity)
        {
            rbRobot.velocity = rbRobot.velocity * (maxVelocity / rbRobot.velocity.magnitude);
        }
    }

    void OnCollisionEnter(Collision o)
    {
        if (o.collider.tag == "Cone")
        {
            coneCounter++;
            txtConeCounter.text = coneCounter.ToString();
        }
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
