using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TimeKeeper : MonoBehaviour {

    public static System.DateTime currentDateTime;
    System.DateTime lastDateTime;

    System.DateTime startDateTime;
    System.DateTime endDateTime;
    public static System.TimeSpan inGameElapsedTime;

    private void Start() {
        SaveLoad.Load();

        lastDateTime = SaveLoad.lastDateTime;
        currentDateTime = System.DateTime.Now;
        startDateTime = System.DateTime.Now;

        inGameElapsedTime = SaveLoad.totalInGameElapsedTime;
        Debug.Log(SaveLoad.totalInGameElapsedTime);

        System.TimeSpan span = currentDateTime.Subtract(lastDateTime);
        Debug.Log(span.Days + " days, " + span.Hours + " hours, " + span.Minutes + " mins, " + span.Seconds);
    }
    
    void Update() {
        currentDateTime = System.DateTime.Now;
    }
    
    private void OnApplicationQuit() {
        endDateTime = System.DateTime.Now;

        inGameElapsedTime = endDateTime.Subtract(startDateTime);
        Debug.Log(inGameElapsedTime);

        SaveLoad.Save();
        //Debug.Log("save");
    }
}