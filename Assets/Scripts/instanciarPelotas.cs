using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarPelotas : MonoBehaviour
{
    private float tiempo;
    public GameObject prefabBall;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //Instantiate(prefabBall, new Vector3(4.98f,0.744f,-8f), Quaternion.identity);
        tiempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 5){

            //Instantiate(prefabBall, new Vector3(4.98f,0.744f,-8f), Quaternion.identity);
           // Instantiate(prefabBall, new Vector3(4.98f,0.744f,-7f), Quaternion.identity);

            tiempo = 0;
        }
    }
}
