using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemJS
{
    public string id;
    public string nombre;
    public string icono;
    public string descripcion;
    public string resistencia;
    public string cantidad;

    public override string ToString()
    {
        return string.Format("id {0}: nombre {1} icono {2} descripcion {3} resistencia {4} cantidad {5}", id, nombre, icono, descripcion, resistencia, cantidad);
    }

}
