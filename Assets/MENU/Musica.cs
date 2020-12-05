using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;
using System.IO;

public class Musica : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider VolumeS;
    public AudioSource myMusic;
    public GameObject opciones;


    // Update is called once per frame
    void Awake()
    {

        

    }

    public void VolumeSli(){
         
         GameObject.Find("VolumeSource").GetComponent<AudioSource>().volume = GameObject.Find("VolumenS").GetComponent<Slider>().value;

    }

}
