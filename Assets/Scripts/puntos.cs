using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class puntos : MonoBehaviour
{
    public GameObject menuPausaUI;
    public GameObject HUDUI;
    public Text myScore;
    public Text rivScore;
    public Text mySets;
    public Text rivSets;
    public GameObject ganasteUI;
    public GameObject perdisteUI;
    public bool cambiarYo = true;
    public bool cambiarRiv = true;
    public bool activar = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = PlayerPrefs.GetInt("myScore").ToString();
        rivScore.text = PlayerPrefs.GetInt("rivScore").ToString();
        mySets.text = PlayerPrefs.GetInt("mySets").ToString();
        rivSets.text = PlayerPrefs.GetInt("rivSets").ToString();

        if(PlayerPrefs.GetInt("myScore") == 40){
            if(cambiarYo == true){
                int set = PlayerPrefs.GetInt("mySets");
                PlayerPrefs.SetInt("mySets", set + 1);
            }
            if(PlayerPrefs.GetInt("mySets") >= 3){
                if(activar == true){
                    cambiarYo = false;
                    ganasteUI.SetActive(true);
                    menuPausaUI.SetActive(false);
                    HUDUI.SetActive(false);
                    Time.timeScale = 0f;
                    activar = false;
                }
            }else{
                variables();
                SceneManager.LoadScene(1);
            }
        }

        if(PlayerPrefs.GetInt("rivScore") == 40){
            if(cambiarRiv == true){
                int set = PlayerPrefs.GetInt("rivSets");
                PlayerPrefs.SetInt("rivSets", set + 1);
            }
            if(PlayerPrefs.GetInt("rivSets") >= 3){
                if(activar == true){
                    cambiarRiv = false;
                    perdisteUI.SetActive(true);
                    menuPausaUI.SetActive(false);
                    HUDUI.SetActive(false);
                    Time.timeScale = 0f;
                    activar = false;
                }
            }else{
                variables();
                SceneManager.LoadScene(1);
            }
        }

    }

    public void variables(){
        PlayerPrefs.SetInt("myScore", 0);
        PlayerPrefs.SetInt("rivScore", 0);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0); //0 no, 1 si
        PlayerPrefs.SetInt("pego2", 0);
    }

}
