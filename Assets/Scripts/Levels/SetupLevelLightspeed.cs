using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupLevelLightspeed : ScriptableObject
{
    public void SetupLevel()
    {
        GameObject newObj;

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "A6";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B1";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B3";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B4";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B6";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B7";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B9";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B11";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "C9";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D1";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D3";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D4";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D6";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D7";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D8";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D9";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D10";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        // start gate
        int i = 0;
        newObj = Instantiate(CourseManager.instance.startGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A2");
        GateManager.AddGate(newObj, i++);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B5");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C6");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B8");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A9");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B10");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E11");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E7");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D5");
        GateManager.AddGate(newObj, i++, true);

        // Finish First Lap

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C3");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B2");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B5");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C6");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B8");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "A9");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "B10");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E11");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E7");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D5");
        GateManager.AddGate(newObj, i++, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C3");
        GateManager.AddGate(newObj, i++, true);

        // finish
        newObj = Instantiate(CourseManager.instance.finishGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E2");
        GateManager.AddGate(newObj, i++);

        GateManager.SetLastGate(i);
        GateManager.ResetGates();
    }
}
