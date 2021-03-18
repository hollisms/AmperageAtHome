using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupLevelBounce : ScriptableObject
{
    public void SetupLevel()
    {
        GameObject newObj;

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B1";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B2";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B4";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B5";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B7";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B8";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B10";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B11";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D1";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D2";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D3";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D5";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D7";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D8";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D10";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D11";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "E3";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.startGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C2");
        GateManager.AddGate(newObj, 0);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A3");
        GateManager.AddGate(newObj, 1, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D4");
        GateManager.AddGate(newObj, 2, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E5");
        GateManager.AddGate(newObj, 3, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A6");
        GateManager.AddGate(newObj, 4, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E7");
        GateManager.AddGate(newObj, 5, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A9");
        GateManager.AddGate(newObj, 6, true);

        newObj = Instantiate(CourseManager.instance.finishGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C10");
        GateManager.AddGate(newObj, 7);

        GateManager.SetLastGate(7);
        GateManager.ResetGates();
    }
}
