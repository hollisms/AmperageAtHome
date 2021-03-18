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

        bounceRacingCourse.SetupLevel();
    }

    // Update is called once per frame

}
