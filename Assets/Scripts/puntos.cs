using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    public Text myScore;
    public Text rivScore;
    public Text mySets;
    public Text rivSets;


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
    }
}
