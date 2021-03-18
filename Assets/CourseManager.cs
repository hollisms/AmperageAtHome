using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseManager : MonoBehaviour
{
    public GameObject cone;
    public GameObject startGate;
    public GameObject nextGate;
    public GameObject finishGate;

    static public CourseManager instance = null;

    static public SetupLevelBarrelRacing barrelRacingCourse = null;
    static public SetupLevelSlalom slalomRacingCourse = null;
    static public SetupLevelBounce bounceRacingCourse = null;
    static public SetupLevelLightspeed lightSpeedRacingCourse = null;

    static public int currentCourse = 0;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        if (barrelRacingCourse == null)
        {
            barrelRacingCourse = ScriptableObject.CreateInstance<SetupLevelBarrelRacing>();
        }

        if (slalomRacingCourse == null)
        {
            slalomRacingCourse = ScriptableObject.CreateInstance<SetupLevelSlalom>();
        }

        if (bounceRacingCourse == null)
        {
            bounceRacingCourse = ScriptableObject.CreateInstance<SetupLevelBounce>();
        }

        if (lightSpeedRacingCourse == null)
        {
            lightSpeedRacingCourse = ScriptableObject.CreateInstance<SetupLevelLightspeed>();
        }

        switch (currentCourse)
        {
            case 0:
                barrelRacingCourse.SetupLevel();
                break;
            case 1:
                bounceRacingCourse.SetupLevel();
                break;
            case 2:
                slalomRacingCourse.SetupLevel();
                break;
            case 3:
                lightSpeedRacingCourse.SetupLevel();
                break;
            default:
                Debug.LogError("No course loaded!");
                break;
        }
    }

    // Update is called once per frame

}
