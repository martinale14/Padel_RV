using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiCom : MonoBehaviour
{
    public GameObject pelota;
    public TurnOnGRavity bola;
    public float velocidad;
    public float impulseRegre;
    public float factElev;

    public float disToReb;

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
            GetComponent<Animator>().SetFloat("VelocidadX", offset.z);

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Bola")){

            bola.rb.velocity = Vector3.zero;
            bola.rb.angularVelocity = Vector3.zero;
            Vector3 dir = GameObject.Find("palaOp").transform.position-bola.transform.position;
            dir.x += disToReb;
            dir.Normalize();
            dir.y = 1;
            print("PalaOp" + GameObject.Find("palaOp").transform.position);
            print("bola" + bola.transform.position);
            print("dir" + dir);
            bola.rb.AddForce(new Vector3(dir.x*impulseRegre, dir.y * factElev, dir.z * impulseRegre), ForceMode.Impulse);
            Physics.IgnoreCollision(GameObject.Find("palaOp").GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>(), false);
            bola.turnoCom = false;
        }
    }

    
}
