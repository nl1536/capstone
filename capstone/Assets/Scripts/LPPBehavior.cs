using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPPBehavior : MonoBehaviour {

    float sec;
    int min, hour, day, week, month, year;

    void Start() {
        
    }
    
    void Update() {
        
        sec += Time.deltaTime;

        if (sec >= 60f) {
            min += 1;
            sec = 0f;
        }
        if (min == 60) {
            hour += 1;
            min = 0;
        }
        if (hour == 24) {
            day += 1;
            hour = 0;
        }
        if (day == 7) {
            week += 1;
            day = 0;
        }
        if (week == 4) {
            month += 1;
            week = 0;
        }
        if (month == 12) {
            year += 1;
            month = 0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            sec += 1f;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            min += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            hour += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            day += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)) {
            week += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha6)) {
            month += 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha7)) {
            year += 1;
        }

        Debug.Log(sec + ", " + min + ", " + hour + ", " + day + ", " + week + ", " + month + ", " + year);
    }

    void OnApplicationQuit() {

    }
}
