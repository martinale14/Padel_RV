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
    private ParticleSystem hit;

    private AudioClip hitSound;

    public float disToReb;
    private Vector3 posIn;

    // Start is called before the first frame update
    void Start()
    {
        posIn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(bola.turnoCom == true){

            Vector3 offset = pelota.transform.position - transform.position;
            print(offset.magnitude);
            if(offset.magnitude < 3){
                //transform.Translate(new Vector3(0,0,offset.z)*velocidad);
            }else{
                //if(transform.position.x < posIn.x){
                  //  transform.Translate(new Vector3(-1,0,0)*Time.deltaTime);
                //}
            }
            if(offset.y > 1){
                
            }
            offset = offset.normalized;
            offset.y = 0;
            offset.x = 0;
            if(transform.position.z < -2.5 && transform.position.z > -12.5){
                transform.position = new Vector3(transform.position.x,transform.position.y,bola.transform.position.z);
                //if(offset.magnitude != 0){
                  //  transform.Translate(new Vector3(0,0,offset.x)*velocidad);
                //}
            }
            //GetComponent<Animator>().SetFloat("VelocidadX", offset.z);

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Bola")){
            hit = bola.hit;
            hitSound = bola.hitSound;
            bola.rb.velocity = Vector3.zero;
            bola.rb.angularVelocity = Vector3.zero;
            Vector3 dir = GameObject.Find("palaOp").transform.position-bola.transform.position;
            dir.x += disToReb;
            dir.Normalize();
            dir.y = 1;
            ParticleSystem.Instantiate(hit, collision.contacts[0].point, Quaternion.identity);
            AudioSource.PlayClipAtPoint(hitSound, collision.contacts[0].point);
            bola.rb.AddForce(new Vector3(dir.x*impulseRegre, dir.y * factElev, dir.z * impulseRegre), ForceMode.Impulse);
            Physics.IgnoreCollision(GameObject.Find("palaOp").GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>(), false);
            bola.turnoCom = false;
        }
    }

    
}
