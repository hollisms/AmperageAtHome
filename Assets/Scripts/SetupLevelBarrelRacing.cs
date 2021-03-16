using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetupLevelBarrelRacing : MonoBehaviour
{
    public GameObject cone;
    public GameObject startGate;
    public GameObject nextGate;
    public GameObject finishGate;

    void Awake() {
        GameObject newObj;
        Vector3 v;
        TextMeshPro textmeshPro;

        Instantiate(cone);
        cone.name = "B1";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);
        
        Instantiate(cone);
        cone.name = "B2";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);
        
        Instantiate(cone);
        cone.name = "B8";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);
        
        Instantiate(cone);
        cone.name = "D1";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);
        
        Instantiate(cone);
        cone.name = "D2";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);
        
        Instantiate(cone);
        cone.name = "D5";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);
        
        Instantiate(cone);
        cone.name = "D10";
        UtilityHelpers.MoveObjectToGridLocation(cone, cone.name);

        newObj = Instantiate(startGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "C2");

        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        GateManager.AddGate(newObj, 0);    

        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "C5");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("1");
        GateManager.AddGate(newObj, 1);    

        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "E5");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("2");
        GateManager.AddGate(newObj, 2);    

        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "D4");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("3");
        GateManager.AddGate(newObj, 3);    

        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "C8");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("4");
        GateManager.AddGate(newObj, 4);    

        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "A8");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("5");
        GateManager.AddGate(newObj, 5);    
        
        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "B7");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("6");
        GateManager.AddGate(newObj, 6);    
        
        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "E10");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("7");
        GateManager.AddGate(newObj, 7);    
        
        newObj = Instantiate(nextGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "C10");
        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        textmeshPro = newObj.GetComponentInChildren<TextMeshPro>();
        textmeshPro.SetText("8");
        GateManager.AddGate(newObj, 8);    

        newObj = Instantiate(finishGate);
        UtilityHelpers.MoveObjectToGridLocation(newObj, "C2");

        v = newObj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        newObj.transform.position = v;
        GateManager.AddGate(newObj, 9);

        GateManager.ResetGates();
    }
}
