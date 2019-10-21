using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveLoad {

    public static System.DateTime lastDateTime;

    public static void Save() {
        lastDateTime = TimeKeeper.currentDateTime;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file;

        if(!File.Exists(Application.persistentDataPath + "/timeValues.gd")) {
            file = File.Create(Application.persistentDataPath + "/timeValues.gd");
        } else {
            File.Delete(Application.persistentDataPath + "/timeValues.gd");
            file = File.Create(Application.persistentDataPath + "/timeValues.gd");
        }

        bf.Serialize(file, lastDateTime);
        file.Close();
    }

    public static void Load() {
        if(File.Exists(Application.persistentDataPath + "/timeValues.gd")) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/timeValues.gd", FileMode.Open);
            lastDateTime = (System.DateTime)bf.Deserialize(file);
            file.Close();
        }
    }
}