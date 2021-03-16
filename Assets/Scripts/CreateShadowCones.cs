using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShadowCones : MonoBehaviour
{
    public GameObject transparentCone;

    // Create a shadow cone very every cone in the scene
    void Start() {

        GameObject[] cones ;

        cones = GameObject.FindGameObjectsWithTag("Cone");
        foreach(GameObject cone in cones) {
            //Debug.Log("Cone Name: " + cone.name);
            Instantiate(transparentCone, cone.transform.position, cone.transform.rotation);
            transparentCone.name = cone.name;
        }
    }
}
