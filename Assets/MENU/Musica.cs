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
    private XmlDocument pref;
    private XmlTextWriter writer;
    private XmlNodeList xmlNode;

    // Update is called once per frame
    void Awake()
    {
        pref = new XmlDocument();
        if(File.Exists("./pref.xml")){
            FileStream fs = new FileStream("pref.xml", FileMode.Open, FileAccess.Read);
            pref.Load(fs);
            xmlNode = pref.GetElementsByTagName("volume");
            print(xmlNode);
        }else{
            pref.LoadXml("<sample><sample>");
            writer = new XmlTextWriter("pref.xml", null);
        }
       myMusic = GameObject.Find("Musiquita").GetComponent<AudioSource>();

    }

    public void VolumeSli(){
         
         VolumeS = GameObject.Find("VolumenS").GetComponent<Slider>();
         myMusic.volume = VolumeS.value;
    }
}
