using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class ItemDB : MonoBehaviour {

    public static List<Item> savedGames = new List<Item>();


    public static void Save(Item pregunta)
    {
        savedGames.Add(pregunta);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/ejemplo.gd");
        bf.Serialize(file, ItemDB.savedGames);
        file.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/ejemplo.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/ejemplo.gd", FileMode.Open);
            ItemDB.savedGames = (List<Item>)bf.Deserialize(file);
            file.Close();
        }
    }
}
