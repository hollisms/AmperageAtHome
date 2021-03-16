using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideControlOnWinPlatform : MonoBehaviour
{
    public bool Enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        if (!Enabled) return;

        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            GameObject obj = this.gameObject;
            obj.SetActive(false);
        }
    }
}
