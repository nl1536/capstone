using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TimeKeeper : MonoBehaviour {

    public static System.DateTime currentDateTime;
    System.DateTime lastDateTime;

    private void Start() {
        SaveLoad.Load();

        lastDateTime = SaveLoad.lastDateTime;
        currentDateTime = System.DateTime.Now;

        System.TimeSpan span = currentDateTime.Subtract(lastDateTime);
        Debug.Log(span.Days + " days, " + span.Hours + " hours, " + span.Minutes + " mins, " + span.Seconds);
    }
    
    void Update() {
        currentDateTime = System.DateTime.Now;
    }
    
    private void OnApplicationQuit() {
        SaveLoad.Save();
        Debug.Log("save");
    }
}