﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        fuente.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EmpezarJuego()
    {
        print("Empezando ...");
        SceneManager.LoadScene(1);

    }
    public void CerrarJuego() {
        Application.Quit();
        Debug.Log("Salir");
    }

    public void reproducir(){
        
        fuente.Play();
    }

}
