using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonSavedLoad : MonoBehaviour {

    string filePath;
    string jsonString;

    ItemJS item = new ItemJS();

    private void Awake()
    {
        
        
    }

    // Use this for initialization
    void Start()
    {
        CargaDatos();
        GuardarDatos("12", "Gorra", "jpg", "de lana", "44", "2");
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CargaDatos()
    {
        filePath = Application.dataPath + @"\Item.json";
        jsonString = File.ReadAllText(filePath);
        item = JsonUtility.FromJson<ItemJS>(jsonString);
        Debug.Log(item);
    }

    void GuardarDatos(string id, string nombre, string icono, string descripcion, string resistencia, string cantidad)
    {
        item.id = id;
        item.nombre = nombre;
        item.icono = icono;
        item.descripcion = descripcion;
        item.resistencia = resistencia;
        item.cantidad = cantidad;
        
        jsonString = JsonUtility.ToJson(item);
        File.WriteAllText(filePath, jsonString);
    }
}
