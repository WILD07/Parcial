using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour {

    int x;
    int y;
    
    // Use this for initialization
    void Start()
    {
        GuardaPuntos();
        CargaPuntos();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GuardaPuntos()
    {
        PlayerPrefs.SetInt("X", Random.Range(1,100));
        PlayerPrefs.SetInt("Y", Random.Range(101,102));
    }

    void CargaPuntos()
    {
        x = PlayerPrefs.GetInt("X", 0);
        y = PlayerPrefs.GetInt("Y", 0);
        Debug.Log("X: " + x);
        Debug.Log("Y: " + y);
    }
}
