using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnGRavity : MonoBehaviour
{
    // Private Variables
    private Rigidbody rb;
    private int refe;
    private float time;

    // Public Variables
    public float impulse;       
    public float factorGolp;
    public float factorElev;
    public ParticleSystem hit;
    public AudioClip hitSound;
    public bool turnoCom = false;
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
        if(collision.gameObject.name.Equals("pala") && turnoCom == false){

            Vector3 dir;
            float colForce;

            dir = collision.contacts[0].point - transform.position;
            Physics.IgnoreCollision(GameObject.Find("pala").GetComponent<Collider>(), GetComponent<Collider>());

            colForce = collision.impulse.magnitude;

            dir = -dir.normalized;

            dir.y = 1;

            ParticleSystem.Instantiate(hit, collision.contacts[0].point, Quaternion.identity);
            AudioSource.PlayClipAtPoint(hitSound, collision.contacts[0].point);

            Vector3 fuerzaRegreso = new Vector3(dir.x * colForce * factorGolp, dir.y * factorElev, dir.z * colForce * factorGolp);

            rb.AddForce(fuerzaRegreso, ForceMode.Impulse);

            turnoCom = true;

        }

    }

}
