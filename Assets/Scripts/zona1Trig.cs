using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zona1Trig : MonoBehaviour
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

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("Bola")){
            //print("pego1");
            int rebote = PlayerPrefs.GetInt("rebote1");
            PlayerPrefs.SetInt("pego1", 1);
            PlayerPrefs.SetInt("pego2", 0);
            PlayerPrefs.SetInt("rebote1", rebote + 1);
            PlayerPrefs.SetInt("rebote2", 0);
            if(turno.turnoCom == false){
                if(PlayerPrefs.GetInt("myScore") < 30){
                    resetear();
                }else{

                }
            }else{
                if(PlayerPrefs.GetInt("rebote1") > 1){
                    if(PlayerPrefs.GetInt("myScore") < 30){
                        resetear();
                    }else{

                    }
                }
                
            }
        }
    }

    public void resetear(){
        int score = PlayerPrefs.GetInt("myScore");
        PlayerPrefs.SetInt("myScore", score + 10);
        PlayerPrefs.SetInt("rebote1", 0);
        PlayerPrefs.SetInt("rebote2", 0);
        PlayerPrefs.SetInt("pego1", 0);
        PlayerPrefs.SetInt("pego2", 0);
        SceneManager.LoadScene(1);
    }

}
