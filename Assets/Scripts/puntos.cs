using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    public Text myScore;
    public Text rivScore;
    public Text mySets;
    public Text rivSet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = PlayerPrefs.GetInt("myScore").ToString();
    }
}
