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
    private XmlDocument pref;
    private XmlTextWriter writer;
    private XmlNodeList xmlNode;
    private float vol;
    private FileStream fs;

    // Update is called once per frame
    void Awake()
    {
        opciones = GameObject.Find("Opciones");

        VolumeS = GameObject.Find("VolumenS").GetComponent<Slider>();

        pref = new XmlDocument();
        fs = new FileStream("./Assets/MENU/pref.xml", FileMode.Open, FileAccess.ReadWrite);
        pref.Load(fs);
        xmlNode = pref.GetElementsByTagName("Volume");
        print(float.Parse(xmlNode.Item(0).InnerText));

       myMusic = GameObject.Find("Musiquita").GetComponent<AudioSource>();

       vol = float.Parse(xmlNode.Item(0).InnerText);

        VolumeS.value = vol;

        fs.Close();

        opciones.SetActive(false);
    }

    public void VolumeSli(){
         
         fs = new FileStream("./Assets/MENU/pref.xml", FileMode.Open, FileAccess.ReadWrite);
         xmlNode.Item(0).InnerText = VolumeS.value.ToString(); 
         myMusic.volume = VolumeS.value;
         pref.Save("./Assets/MENU/pref.xml");
         fs.Close();
    }

}
