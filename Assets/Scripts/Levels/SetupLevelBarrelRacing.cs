using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupLevelBarrelRacing : ScriptableObject
{
    public void SetupLevel()
    {
        GameObject newObj;

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B1";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B2";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B8";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D1";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D2";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D5";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D10";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        newObj = Instantiate(CourseManager.instance.startGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C2");
        GateManager.AddGate(newObj, 0);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C5");
        GateManager.AddGate(newObj, 1, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E5");
        GateManager.AddGate(newObj, 2, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D4");
        GateManager.AddGate(newObj, 3, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C8");
        GateManager.AddGate(newObj, 4, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A8");
        GateManager.AddGate(newObj, 5, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B7");
        GateManager.AddGate(newObj, 6, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E10");
        GateManager.AddGate(newObj, 7, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C10");
        GateManager.AddGate(newObj, 8, true);

        newObj = Instantiate(CourseManager.instance.finishGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C2");
        GateManager.AddGate(newObj, 9);

        GateManager.SetLastGate(9);
        GateManager.ResetGates();
    }
}
