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
        tiempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 5){

            Instantiate(prefabBall, new Vector3(4.98f,0.744f,-0.83f), Quaternion.identity);

            tiempo = 0;
        }
    }
}
