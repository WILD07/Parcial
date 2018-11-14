using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jugador
{

    public int id;
    public string nombre;
    public string icono;
    public string descripcion;
    public int resistencia;
    public int cantidad;

    public Jugador(int id, string nombre, string icono, string descripcion, int resistencia, int cantidad)
    {
        this.id = id;
        this.nombre = nombre;
        this.icono = icono;
        this.descripcion = descripcion;
        this.resistencia = resistencia;
        this.cantidad = cantidad;
    }
}
