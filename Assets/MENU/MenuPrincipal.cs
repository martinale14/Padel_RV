using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("myScore", 0);
        PlayerPrefs.SetInt("rivScore", 0);
        PlayerPrefs.SetInt("mySets", 0);
        PlayerPrefs.SetInt("rivSets", 0);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0); //0 no, 1 si
        PlayerPrefs.SetInt("pego2", 0); //0 no, 1 si
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EmpezarJuego()
    {

        SceneManager.LoadScene(1);

    }
    public void CerrarJuego() {
        Application.Quit();
        Debug.Log("Salir");
    }

}
