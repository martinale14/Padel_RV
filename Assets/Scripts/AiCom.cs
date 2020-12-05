using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiCom : MonoBehaviour
{
    public GameObject pelota;
    public TurnOnGRavity bola;
    public float velocidad;
    public float impulseRegre;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        if(bola.turnoCom == true){

            Vector3 offset = pelota.transform.position - transform.position;
            offset = offset.normalized;
            offset.y = 0;
            offset.x = 0;
            transform.position = new Vector3(transform.position.x,transform.position.y,bola.transform.position.z);
            GetComponent<Animator>().SetFloat("VelocidadZ", offset.z);

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Bola")){

            bola.rb.velocity = Vector3.zero;
            bola.rb.angularVelocity = Vector3.zero;
            bola.rb.AddForce((Vector3.up + Vector3.left)*impulseRegre, ForceMode.Impulse);
            Physics.IgnoreCollision(GameObject.Find("palaOp").GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>(), false);
            bola.turnoCom = false;
        }
    }

    
}
