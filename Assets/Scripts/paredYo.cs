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
                    PlayerPrefs.SetInt("pego2", 0);
                    if(PlayerPrefs.GetInt("rivScore") < 30){
                    int score = PlayerPrefs.GetInt("rivScore");
                    PlayerPrefs.SetInt("rivScore", score + 10);
                    SceneManager.LoadScene(1);
                    }else{

                    }
                }
            }else{
                if(PlayerPrefs.GetInt("rivScore") < 30){
                    int score = PlayerPrefs.GetInt("rivScore");
                    PlayerPrefs.SetInt("rivScore", score + 10);
                    SceneManager.LoadScene(1);
                }else{

                }
            }
        }
    }

}
