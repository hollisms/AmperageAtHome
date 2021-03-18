using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupLevelLightspeed : ScriptableObject
{
    public void SetupLevel()
    {
        // setup player
        Vector3 v;
        GameObject player = GameObject.Find("Robot1");

        if (!player)
        {
            Debug.LogError("Player Object Robot1 could not be found.");
            return;
        }
        v = player.transform.position;
        v.z = 1.1f;
        player.transform.position = v;

        Quaternion q = player.transform.rotation;
        v = q.eulerAngles;
        v.y = 270.0f;
        q.eulerAngles = v;
        player.transform.rotation = q;

        // setup cones
        GameObject newObj;

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "A6";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B1";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B3";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B4";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B6";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B7";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B9";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "B11";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "C9";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D1";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D3";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D4";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D6";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D7";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D8";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D9";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

        newObj = Instantiate(CourseManager.instance.cone);
        newObj.name = "D10";
        UtilityHelpers.MoveConeToGridLocation(newObj, newObj.name);

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
        GateManager.AddGate(newObj, i);

        GateManager.SetLastGate(i);
        GateManager.ResetGates();
    }
}
