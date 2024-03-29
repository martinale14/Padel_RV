﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuPausaUI;
    public GameObject HUDUI;
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused == false){
                pause();
            }else{
                resume();
            }
        }

        if(Input.GetKeyDown("r")){

            reiniciar();

        }
    }

    public void pause(){
        menuPausaUI.SetActive(true);
        HUDUI.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resume(){
        menuPausaUI.SetActive(false);
        HUDUI.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void reiniciar(){
        PlayerPrefs.SetInt("myScore", 0);
        PlayerPrefs.SetInt("rivScore", 0);
        PlayerPrefs.SetInt("mySets", 0);
        PlayerPrefs.SetInt("rivSets", 0);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0);
        PlayerPrefs.SetInt("pego2", 0);
        SceneManager.LoadScene(1);
        resume();
    }

    public void salir(){
        menuPausaUI.SetActive(false);
        HUDUI.SetActive(true);
        isPaused = false;
        SceneManager.LoadScene(0);
    }

}
