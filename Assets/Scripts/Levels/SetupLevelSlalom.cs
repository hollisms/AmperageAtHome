using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupLevelSlalom : ScriptableObject
{
    public void SetupLevel()
    {
        // move player to 3.7
        Vector3 v;
        GameObject player = GameObject.Find("Robot1");

        if (!player)
        {
            Debug.LogError("Player Object Robot1 could not be found.");
            return;
        }
        v = player.transform.position;
        v.x = 3.7f;
        player.transform.position = v;

        GameObject newObj;

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B1";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "B2";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D1";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D2";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D4";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D5";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D6";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D7";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        Instantiate(CourseManager.instance.cone);
        CourseManager.instance.cone.name = "D10";
        UtilityHelpers.MoveConeToGridLocation(CourseManager.instance.cone, CourseManager.instance.cone.name);

        newObj = Instantiate(CourseManager.instance.startGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E2");
        GateManager.AddGate(newObj, 0);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D3");
        GateManager.AddGate(newObj, 1, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C6");
        GateManager.AddGate(newObj, 2, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D9");
        GateManager.AddGate(newObj, 3, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E10");
        GateManager.AddGate(newObj, 4, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D11");
        GateManager.AddGate(newObj, 5, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C10");
        GateManager.AddGate(newObj, 6, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D9");
        GateManager.AddGate(newObj, 7, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "E6");
        GateManager.AddGate(newObj, 8, true);

        newObj = Instantiate(CourseManager.instance.nextGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "D3");
        GateManager.AddGate(newObj, 9, true);

        newObj = Instantiate(CourseManager.instance.finishGate);
        UtilityHelpers.MoveGateToGridLocation(newObj, "C2");
        GateManager.AddGate(newObj, 10);

        GateManager.SetLastGate(10);
        GateManager.ResetGates();
    }
}
