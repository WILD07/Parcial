using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string id;
    public string nombre;
    public string icono;
    public string descripcion;
    public string resistencia;
    public string cantidad;

    public Item(string id, string nombre, string icono, string descripcion, string resistencia, string cantidad)
    {
        this.id = id;
        this.nombre = nombre;
        this.icono = icono;
        this.descripcion = descripcion;
        this.resistencia = resistencia;
        this.cantidad = cantidad;
    }
}
