using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TimeKeeper : MonoBehaviour {

    public static float currentSec;
    public static int currentMin, currentHour, currentDay, currentWeek, currentMonth, currentYear;

    public float sec;
    public int min, hour, day, week, month, year;

    private void Start() {
        SaveLoad.Load();

        Debug.Log(SaveLoad.lastSec);

        currentSec = SaveLoad.lastSec;
        currentMin = SaveLoad.lastMin;
        currentHour = SaveLoad.lastHour;
        currentDay = SaveLoad.lastDay;
        currentWeek = SaveLoad.lastWeek;
        currentMonth = SaveLoad.lastMonth;
        currentYear = SaveLoad.lastYear;
    }

    void Update() {
        currentSec += Time.deltaTime;

        if(currentSec >= 60f) {
            currentMin += 1;
            currentSec = 0f;
        }
        if(currentMin == 60) {
            currentHour += 1;
            currentMin = 0;
        }
        if(currentHour == 24) {
            currentDay += 1;
            currentHour = 0;
        }
        if(currentDay == 7) {
            currentWeek += 1;
            currentDay = 0;
        }
        if(currentWeek == 4) {
            currentMonth += 1;
            currentWeek = 0;
        }
        if(currentMonth == 12) {
            currentYear += 1;
            currentMonth = 0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            currentSec += 1f;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            currentMin += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            currentHour += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            currentDay += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)) {
            currentWeek += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha6)) {
            currentMonth += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha7)) {
            currentYear += 1;
        }

        Debug.Log(currentSec + ", " + currentMin + ", " + currentHour + ", " + currentDay + ", " + currentWeek + ", " + currentMonth + ", " + currentYear);
    }

    private void OnApplicationQuit() {
        SaveLoad.Save();
        Debug.Log("save");
    }
}
