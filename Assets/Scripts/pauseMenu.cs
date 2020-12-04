using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuPausaUI;
    public GameObject HUDUI;
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause(){
        menuPausaUI.SetActive(true);
        HUDUI.SetActive(false);
        Time.timeScale = 0f;
    }

    public void resume(){
        menuPausaUI.SetActive(false);
        HUDUI.SetActive(true);
        Time.timeScale = 1f;
    }

}
