using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {

    public Text idTexto;
    public Text nombreTexto;
    public Text iconoTexto;
    public Text descripcionTexto;
    public Text resistenciaTexto;
    public Text cantidadTexto;

    Item datos;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GuardaDatos()
    {
        datos = new Item(idTexto.text, nombreTexto.text, iconoTexto.text, descripcionTexto.text, resistenciaTexto.text, cantidadTexto.text);
        ItemDB.Load();
        ItemDB.Save(datos);
    }

    public void RecuperaDatos()
    {
        ItemDB.Load();
        foreach (Item aux in ItemDB.savedGames)
        {
            Debug.Log("id " + aux.id);
            Debug.Log("Nombre " + aux.nombre);
            Debug.Log("Icono " + aux.icono);
            Debug.Log("Descripcion " + aux.descripcion);
            Debug.Log("Resistencia " + aux.resistencia);
            Debug.Log("Cantidad " + aux.cantidad);
        }
    }
}
