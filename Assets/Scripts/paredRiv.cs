using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paredRiv : MonoBehaviour
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
                if(PlayerPrefs.GetInt("pego1") == 1){
                    PlayerPrefs.SetInt("pego1", 0);
                    if(PlayerPrefs.GetInt("myScore") < 30){
                    int score = PlayerPrefs.GetInt("myScore");
                    PlayerPrefs.SetInt("myScore", score + 10);
                    SceneManager.LoadScene(1);
                    }else{

                    }
                }
            }else{
                if(PlayerPrefs.GetInt("myScore") < 30){
                    int score = PlayerPrefs.GetInt("myScore");
                    PlayerPrefs.SetInt("myScore", score + 10);
                    SceneManager.LoadScene(1);
                }else{

                }
            }
        }
    }

}
