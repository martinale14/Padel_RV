using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public GameObject menuPausaUI;
    public GameObject HUDUI;
    public GameObject ganasteUI;
    public GameObject perdisteUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")){
            reiniciar();
        }
    }
    public void reiniciar(){
        variables();
        SceneManager.LoadScene(1);
        menuPausaUI.SetActive(false);
        perdisteUI.SetActive(false);
        ganasteUI.SetActive(false);
        HUDUI.SetActive(true);
        Time.timeScale = 1f;
    }
    public void salir(){
        variables();
        menuPausaUI.SetActive(false);
        perdisteUI.SetActive(false);
        ganasteUI.SetActive(false);
        HUDUI.SetActive(true);
        SceneManager.LoadScene(0);
    }
    public void variables(){
        PlayerPrefs.SetInt("myScore", 0);
        PlayerPrefs.SetInt("rivScore", 0);
        PlayerPrefs.SetInt("mySets", 0);
        PlayerPrefs.SetInt("rivSets", 0);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0);
        PlayerPrefs.SetInt("pego2", 0);
    }
}
