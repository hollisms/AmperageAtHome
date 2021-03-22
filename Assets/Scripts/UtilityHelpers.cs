
using System; // for FirstOrDefault Function
using UnityEngine;
using UnityEngine.SceneManagement;

public static class UtilityHelpers
{
    public static void LoadMainScene()
    {
        SceneManager.LoadScene("Barrel Racing");
    }

    public static void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public static void MoveGateToGridLocation(GameObject obj, string location)
    {
        MoveConeToGridLocation(obj, location);

        Vector3 v;
        v = obj.transform.position;
        v.y = 0.8f;
        v.x -= 0.1f;
        obj.transform.position = v;
    }
    public static void MoveConeToGridLocation(GameObject obj, string location)
    {
        obj.transform.position = GetPositionfromLocation(location);
    }

    public static Vector3 GetPositionfromLocation(string location)
    {

        float offsetX = 0.0f;   // where the grid should start in world space
        float offsetZ = -0.434f;
        float sizeX = 0.762f;  // size of grid 
        float sizeZ = 0.762f;

        Vector3 v = new Vector3(offsetX, 0.2f, offsetZ);

        // I'm sorry?
        switch (location)
        {
            case "A1":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 1);
                break;
            case "A2":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 2);
                break;
            case "A3":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 3);
                break;
            case "A4":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 4);
                break;
            case "A5":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 5);
                break;
            case "A6":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 6);
                break;
            case "A7":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 7);
                break;
            case "A8":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 8);
                break;
            case "A9":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 9);
                break;
            case "A10":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 10);
                break;
            case "A11":
                v.x += (sizeX * 1);
                v.z += (sizeZ * 11);
                break;

            case "B1":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 1);
                break;
            case "B2":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 2);
                break;
            case "B3":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 3);
                break;
            case "B4":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 4);
                break;
            case "B5":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 5);
                break;
            case "B6":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 6);
                break;
            case "B7":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 7);
                break;
            case "B8":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 8);
                break;
            case "B9":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 9);
                break;
            case "B10":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 10);
                break;
            case "B11":
                v.x += (sizeX * 2);
                v.z += (sizeZ * 11);
                break;

            case "C1":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 1);
                break;
            case "C2":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 2);
                break;
            case "C3":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 3);
                break;
            case "C4":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 4);
                break;
            case "C5":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 5);
                break;
            case "C6":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 6);
                break;
            case "C7":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 7);
                break;
            case "C8":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 8);
                break;
            case "C9":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 9);
                break;
            case "C10":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 10);
                break;
            case "C11":
                v.x += (sizeX * 3);
                v.z += (sizeZ * 11);
                break;

            case "D1":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 1);
                break;
            case "D2":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 2);
                break;
            case "D3":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 3);
                break;
            case "D4":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 4);
                break;
            case "D5":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 5);
                break;
            case "D6":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 6);
                break;
            case "D7":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 7);
                break;
            case "D8":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 8);
                break;
            case "D9":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 9);
                break;
            case "D10":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 10);
                break;
            case "D11":
                v.x += (sizeX * 4);
                v.z += (sizeZ * 11);
                break;

            case "E1":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 1);
                break;
            case "E2":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 2);
                break;
            case "E3":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 3);
                break;
            case "E4":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 4);
                break;
            case "E5":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 5);
                break;
            case "E6":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 6);
                break;
            case "E7":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 7);
                break;
            case "E8":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 8);
                break;
            case "E9":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 9);
                break;
            case "E10":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 10);
                break;
            case "E11":
                v.x += (sizeX * 5);
                v.z += (sizeZ * 11);
                break;


            default:
                Debug.Log("Uknown location");
                break;
        }


        return v;
    }


}
