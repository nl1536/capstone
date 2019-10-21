using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveLoad {

    public static float lastSec;
    public static int lastMin, lastHour, lastDay, lastWeek, lastMonth, lastYear;

    public static void Save() {
        lastSec = TimeKeeper.currentSec;
        lastMin = TimeKeeper.currentMin;
        lastHour = TimeKeeper.currentHour;
        lastDay = TimeKeeper.currentDay;
        lastWeek = TimeKeeper.currentWeek;
        lastMonth = TimeKeeper.currentMonth;
        lastYear = TimeKeeper.currentYear;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file;

        if(!File.Exists(Application.persistentDataPath + "/timeValues.gd")) {
            file = File.Create(Application.persistentDataPath + "/timeValues.gd");
        } else {
            File.Delete(Application.persistentDataPath + "/timeValues.gd");
            file = File.Create(Application.persistentDataPath + "/timeValues.gd");
        }

        bf.Serialize(file, lastSec);
        bf.Serialize(file, lastMin);
        bf.Serialize(file, lastHour);
        bf.Serialize(file, lastDay);
        bf.Serialize(file, lastWeek);
        bf.Serialize(file, lastMonth);
        bf.Serialize(file, lastYear);
        file.Close();
    }

    public static void Load() {
        if(File.Exists(Application.persistentDataPath + "/timeValues.gd")) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/timeValues.gd", FileMode.Open);
            lastSec = (float)bf.Deserialize(file);
            lastMin = (int)bf.Deserialize(file);
            lastHour = (int)bf.Deserialize(file);
            lastDay = (int)bf.Deserialize(file);
            lastWeek = (int)bf.Deserialize(file);
            lastMonth = (int)bf.Deserialize(file);
            lastYear = (int)bf.Deserialize(file);
            file.Close();
        }
    }
}
