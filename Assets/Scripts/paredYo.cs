using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class paredYo : MonoBehaviour
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

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Bola")){
            if(turno.turnoCom == true){
                if(PlayerPrefs.GetInt("pego2") == 1){
                    if(PlayerPrefs.GetInt("rivScore") < 30){
                        resetear();
                    }else{
                        
                    }
                }
            }else{
                if(PlayerPrefs.GetInt("rivScore") < 30){
                    resetear();
                }else{

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

}
