using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiCom : MonoBehaviour
{
    public GameObject pelota;
    public TurnOnGRavity bola;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(bola.turnoCom);
        if(bola.turnoCom == true){

            Vector3 offset = pelota.transform.position - transform.position;
            offset = offset.normalized;
            offset.y = 0;
            transform.Translate(offset * velocidad * Time.deltaTime);

        }
    }
}
