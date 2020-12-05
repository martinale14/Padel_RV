using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnGRavity : MonoBehaviour
{
    // Private Variables
    public Rigidbody rb;
    private int refe;
    private float time;

    // Public Variables
    public float impulse;       
    public float factorGolp;
    public float factorElev;
    public ParticleSystem hit;
    public AudioClip hitSound;
    public bool turnoCom = false; //Falso lo tocó la com, verdad lo toqué yo
    public GameObject pelotaPref;


    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
        refe = 0;
        time = 0;

    }

    void Update(){

        time += Time.deltaTime;

        if(time >= 3){
            
            if(refe == 0){

                refe = 1;
                rb.useGravity = true;
                rb.AddForce((Vector3.up + Vector3.left)*impulse, ForceMode.Impulse);

            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("palaOp") && turnoCom == false){

            Vector3 dir;

            dir = collision.contacts[0].point - transform.position;
            Physics.IgnoreCollision(GameObject.Find("palaOp").GetComponent<Collider>(), GetComponent<Collider>(), true);

            dir = -dir.normalized;

            dir.y = 1;

            ParticleSystem.Instantiate(hit, collision.contacts[0].point, Quaternion.identity);
            AudioSource.PlayClipAtPoint(hitSound, collision.contacts[0].point);

            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
            Vector3 fuerzaRegreso = new Vector3(dir.x * factorGolp, dir.y * factorElev, dir.z * factorGolp);

            rb.AddForce(fuerzaRegreso, ForceMode.Impulse);

            turnoCom = true;

        }


    }

}
