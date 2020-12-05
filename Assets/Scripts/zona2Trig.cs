using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zona2Trig : MonoBehaviour
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
            int rebote = PlayerPrefs.GetInt("rebote2");
            PlayerPrefs.SetInt("pego2", 1);
            PlayerPrefs.SetInt("pego1", 0);
            PlayerPrefs.SetInt("rebote2", rebote + 1);
            PlayerPrefs.SetInt("rebote1", 0);
            if(turno.turnoCom == true){
                resetear();
            }else{
                if(PlayerPrefs.GetInt("rebote2") > 1){
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

}
