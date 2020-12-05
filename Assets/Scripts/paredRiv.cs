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
                    resetear();
                }
            }else{
                resetear();
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
