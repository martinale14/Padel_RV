using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public Animator animacion;
    public float velocidad;
    public Rigidbody rb;
    public float impulso;
    // Start is called before the first frame update
    void Start()
    {
        impulso = 200;
        velocidad = 4;
        rb = GetComponent<Rigidbody>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if(Input.GetKeyDown("space")){

            //rb.AddForce(transform.up * impulso, ForceMode.Impulse);
            animacion.SetBool("salto", true);

        }

        if(Input.GetMouseButtonDown(0)){    

            animacion.SetTrigger("Golpe");
            

        }

        transform.Translate(new Vector3(x*Time.deltaTime*velocidad, 0, y*Time.deltaTime*velocidad));
        animacion.SetFloat("VelocidadX", x);
        animacion.SetFloat("VelocidadY", y);
    }

    public void onGround(){

             animacion.SetBool("salto", false);


    }

    public void trigGolpe(){

        animacion.SetTrigger("Golpe");

    }
}
