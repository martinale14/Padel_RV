using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musica : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider Volume;
    public AudioSource myMusic;

    // Update is called once per frame
    void Update()
    {
        myMusic.volume = Volume.value;
    }
}
