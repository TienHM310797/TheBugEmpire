using UnityEngine;
using System;

public class splashControl : MonoBehaviour
{

    void Stasrt()
    {
      
        Invoke("Playasdq", 2);
    }


    void Updwate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Playfasdq()
    {
        Application.LoadLevel("Home");
    }
    void Start()
    {
      
        Invoke("Playasdq", 2);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Playasdq()
    {
        Application.LoadLevel("Home");
    }

  
}
