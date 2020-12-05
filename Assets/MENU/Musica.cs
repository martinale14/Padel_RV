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

        StreamReader sr = new StreamReader("./Assets/MENU/volumen.txt");

        float line = float.Parse(sr.ReadLine());

        sr.Close();

        opciones.SetActive(true);

        VolumeSli(line);

        opciones.SetActive(false);

    }

    public void VolumeSli(){
         
         GameObject.Find("VolumeSource").GetComponent<AudioSource>().volume = GameObject.Find("VolumenS").GetComponent<Slider>().value;
         FileInfo fi = new FileInfo("./Assets/MENU/volumen.txt");
         StreamWriter sw = new StreamWriter(fi.Open(FileMode.Truncate));
         sw.Write(GameObject.Find("VolumenS").GetComponent<Slider>().value.ToString());
         sw.Close();

    }

    public void VolumeSli(float vol){
         
         GameObject.Find("VolumenS").GetComponent<Slider>().value = vol;

    }

}
