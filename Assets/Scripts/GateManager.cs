using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class GateManager
{
    private static float m_lTimerStart = 0;
    private static float m_lElapsedTime = 0;
    private static float m_lTimerStop = 0;
    private static bool m_bTimerRunning = false;

    private static int iCurrentGate = 0;
    private static int iLastGate = 100;
    private static int iMaxGate = 100;
    private static GameObject[] m_Gates = new GameObject[iMaxGate];

    public static void StartTimer()
    {
        m_bTimerRunning = true;
        m_lTimerStart = Time.time;
        m_lElapsedTime = 0;
        m_lTimerStop = 0;
    }

    public static void SetLastGate(int i)
    {
        iLastGate = i;
    }

    public static void StopTimer()
    {
        m_bTimerRunning = false;
        m_lTimerStop = Time.time;
        m_lElapsedTime = m_lTimerStop - m_lTimerStart;
    }

    public static float GetElapsedTime()
    {
        if (m_bTimerRunning)
        {
            return Time.time - m_lTimerStart;
        }

        return m_lElapsedTime;
    }

    public static void AddGate(GameObject obj, int index, bool addNumber = false)
    {
        Debug.Assert(index < iMaxGate, "Number of Gates out of bounds. Index: " + index.ToString() + " iLastGate: " + iMaxGate.ToString());
        m_Gates[index] = obj;

        if (!addNumber) return;

        TextMeshPro textmeshPro = obj.GetComponentInChildren<TextMeshPro>();

        if (textmeshPro == null)
        {
            Debug.LogError("AddGate: Couldn't set text.");
        }
        textmeshPro.SetText(index.ToString());
    }

    public static GameObject GetGate(int index)
    {
        Debug.Assert(index < iLastGate, "Number of Gates out of bounds. Index: " + index.ToString() + " iLastGate: " + iLastGate.ToString());

        return m_Gates[index];
    }

    public static void NextGate()
    {
        iCurrentGate++;

        if (iCurrentGate > iLastGate)
        {
            Debug.Log("Gates have been finished.");
            return;
        }

        m_Gates[iCurrentGate].SetActive(true);
    }

    public static void ResetGates()
    {
        m_bTimerRunning = false;
        m_lTimerStart = 0;
        m_lElapsedTime = 0;
        m_lTimerStop = 0;

        iCurrentGate = 0;
        for (int c = 1; c <= iLastGate; c++)
        {
            Debug.Assert(m_Gates[c] != null, "m_Gates[" + c.ToString() + "] is null.");
            m_Gates[c].SetActive(false);
        }
    }

}
