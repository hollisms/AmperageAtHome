using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



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
    public static int driveType = 0;

    public bool leftHandBrakeOn = false;
    public bool rightHandBrakeOn = false;

    void Start()
    {
        rbLeftMotor = GameObject.Find("LeftMotor").GetComponent<Rigidbody>();
        rbRightMotor = GameObject.Find("RightMotor").GetComponent<Rigidbody>();
    }



    void Awake()
    {
        controls = new PlayerControls();

        // left joystick
        controls.GamePlay.StickLeft.performed += ctx => moveLeft = ctx.ReadValue<Vector2>();
        controls.GamePlay.StickLeft.canceled += ctx => moveLeft = Vector2.zero;

        // right joystick
        controls.GamePlay.StickRight.performed += ctx => moveRight = ctx.ReadValue<Vector2>();
        controls.GamePlay.StickRight.canceled += ctx => moveRight = Vector2.zero;


        // WSAD keys
        controls.GamePlay.KeyMoveForward.performed += ctx => ForwardKey(true);
        controls.GamePlay.KeyMoveForward.canceled += ctx => ForwardKey(false);

        controls.GamePlay.KeyMoveBackward.performed += ctx => BackwardKey(true);
        controls.GamePlay.KeyMoveBackward.canceled += ctx => BackwardKey(false);

        controls.GamePlay.KeyTurnLeft.performed += ctx => LeftKey(true);
        controls.GamePlay.KeyTurnLeft.canceled += ctx => LeftKey(false);

        controls.GamePlay.KeyTurnRight.performed += ctx => RightKey(true);
        controls.GamePlay.KeyTurnRight.canceled += ctx => RightKey(false);

        controls.GamePlay.RestartLevel.performed += ctx => UtilityHelpers.RestartLevel();

        // Handbrakes for tank drive
        controls.GamePlay.LeftHandbrake.performed += ctx => { leftHandBrakeOn = true; };
        controls.GamePlay.LeftHandbrake.canceled += ctx => { leftHandBrakeOn = false; };
        controls.GamePlay.RightHandbrake.performed += ctx => { rightHandBrakeOn = true; };
        controls.GamePlay.RightHandbrake.canceled += ctx => { rightHandBrakeOn = false; };




        // TODO should probably be in Start
        txtConeCounter = GameObject.Find("txtConeCounter").GetComponent<Text>();
        txtConeCounter.text = coneCounter.ToString();
        rbRobot.centerOfMass = Vector3.zero;
    }


    void ForwardKey(bool b)
    {
        if (b) moveLeft.y = 0.75f;
        else moveLeft.y = 0.0f;
    }

    void BackwardKey(bool b)
    {
        if (b) moveLeft.y = -0.75f;
        else moveLeft.y = 0.0f;
    }

    void RightKey(bool b)
    {
        if (b) moveRight.x = 0.75f;
        else moveRight.x = 0.0f;
    }

    void LeftKey(bool b)
    {
        if (b) moveRight.x = -0.75f;
        else moveRight.x = 0.0f;
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
        // if left handbrake pressed then zero left side force
        if (leftHandBrakeOn)
        {
            fL.z = 0;
            fR.z *= 1.5f;

        }
        if (rightHandBrakeOn)
        {
            fR.z = 0.0f;
            fL.z *= 1.5f;
        }

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
        controls.GamePlay.Enable();
    }

    void OnDisable()
    {
        controls.GamePlay.Disable();
    }
}
