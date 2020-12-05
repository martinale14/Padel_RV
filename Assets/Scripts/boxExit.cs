using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boxExit : MonoBehaviour
{
    public TurnOnGRavity turno;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerExit(Collider other) {
        if(other.gameObject.name.Equals("Bola")){
            if(turno.turnoCom == false){
                if(PlayerPrefs.GetInt("pego2") == 1){
                    resetear();
                }else{
                    resetear2();
                }
            }else{
                if(PlayerPrefs.GetInt("pego1") == 1){
                    resetear2();
                }else{
                    resetear();
                }
            }
        }
    }

    public void resetear(){
        int score = PlayerPrefs.GetInt("rivScore");
        PlayerPrefs.SetInt("rivScore", score + 10);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0);
        PlayerPrefs.SetInt("pego2", 0);
        SceneManager.LoadScene(1);
    }

    public void resetear2(){
        int score = PlayerPrefs.GetInt("rivScore");
        PlayerPrefs.SetInt("rivScore", score + 10);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0);
        PlayerPrefs.SetInt("pego2", 0);
        SceneManager.LoadScene(1);
    }

}
