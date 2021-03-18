using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    void Start()
    {
        Button b = null;

        // highlight the selected drive type in the UI
        switch (RobotMovement.driveType)
        {
            case 0:
                Debug.Log("Selecting Arcade button.");
                b = this.transform.FirstOrDefault(x => x.name == "Arcade").GetComponent<Button>();
                break;
            case 1:
                Debug.Log("Selecting Tank button.");
                b = this.transform.FirstOrDefault(x => x.name == "Tank").GetComponent<Button>();
                break;
        }

        if (b == null)
        {
            Debug.LogError("Drive button not found!");
            return;
        }

        b.Select();
    }
    public void ArcadeSelected()
    {
        Debug.Log("Arcade drive selected.");
        RobotMovement.driveType = 0;
    }

    public void TankSelected()
    {
        Debug.Log("Tank drive selected.");
        RobotMovement.driveType = 1;
    }
    public void SwerveSelected()
    {
        Debug.Log("Swerve drive selected, but isn't support yet.");
    }

    public void BarrelRacingSelected()
    {
        Debug.Log("Barrel racing course selected.");
        CourseManager.currentCourse = 0;
        UtilityHelpers.RestartLevel();
    }
    public void BounceSelected()
    {
        Debug.Log("Bounce racing course selected.");
        CourseManager.currentCourse = 1;
        UtilityHelpers.RestartLevel();

    }
    public void SlalomSelected()
    {
        Debug.Log("Slalom racing course selected.");
        CourseManager.currentCourse = 2;
        UtilityHelpers.RestartLevel();

    }
    public void LightSpeedSelected()
    {
        Debug.Log("LightSpeed racing course selected.");
        CourseManager.currentCourse = 3;
        UtilityHelpers.RestartLevel();

    }

}
