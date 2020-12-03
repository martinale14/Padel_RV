using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnGRavity : MonoBehaviour
{
    private Rigidbody rb;
    public float impulse;
    private int refe;
    private float time;
    public int factorGolp;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
        refe = 0;
        time = 0;
        factorGolp = 1;
    }

    void Update(){

        if(refe == 0){

            refe = 1;
            rb.AddForce((Vector3.up + Vector3.left)*impulse, ForceMode.Impulse);

        }

        time += Time.deltaTime;

        if(time > 60){
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("pala")){

            Vector3 dir;
            float colForce;

            dir = collision.contacts[0].point - transform.position;
            colForce = collision.impulse.magnitude;

            dir = -dir.normalized;

            rb.AddForce(dir*colForce*factorGolp, ForceMode.Impulse);

        }

    }

}
