using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_DateTime : MonoBehaviour {

    string lastDateTime;
    string currentDateTime;

    int currentDay;
    int currentMonth;
    int currentYear;
    int currentMin;
    int currentHour;

    int lastDay;
    int lastMonth;
    int lastYear;
    int lastMin;
    int lastHour;

    int timeSpanDay;
    int timeSpanMonth;
    int timeSpanYear;
    int timeSpanMin;
    int timeSpanHour;

    void Start() {
        currentDay = System.DateTime.Now.Day;
        currentMonth = System.DateTime.Now.Month;
        currentYear = System.DateTime.Now.Year;
        currentMin = System.DateTime.Now.Minute;
        currentHour = System.DateTime.Now.Hour;

        if (lastDay == null && lastMonth == null && lastYear == null && lastMin == null && lastHour == null) {
            timeSpanDay = 0;
            timeSpanMonth = 0;
            timeSpanYear = 0;
            timeSpanMin = 0;
            timeSpanHour = 0;
        } else {
            timeSpanDay = currentDay - lastDay;
            timeSpanMonth = currentMonth - lastMonth;
            timeSpanYear = currentYear - lastYear;
            timeSpanMin = currentMin - lastMin;
            timeSpanHour = currentHour - lastHour;
        }
    }
    
    void Update() {
        
    }

    private void OnApplicationQuit() {
        lastDateTime = currentDateTime;

        lastDay = System.DateTime.Now.Day;
        lastMonth = System.DateTime.Now.Month;
        lastYear = System.DateTime.Now.Year;
        lastMin = System.DateTime.Now.Minute;
        lastHour = System.DateTime.Now.Hour;
    }
}
