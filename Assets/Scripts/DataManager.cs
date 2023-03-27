using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class DataManager
{
    public static DataManager DM = new DataManager();

    public void LoadData()
    {
        if (System.IO.File.Exists(Application.persistentDataPath + "/Data.json"))
        {
            DataHandler.Data = JsonUtility.FromJson<DataHandler>(File.ReadAllText(Application.persistentDataPath + "/Data.json"));
        }
        else
        {
            DataHandler.SetDefault();
            SaveData();
        }
    }

    public void SaveData()
    {
        File.WriteAllText(Application.persistentDataPath + "/Data.json", JsonUtility.ToJson(DataHandler.Data));
    }
}