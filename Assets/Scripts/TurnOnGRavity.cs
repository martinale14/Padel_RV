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

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
        refe = 0;
        time = 0;
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

            dir.y = 1;

            print(colForce);

            rb.AddForce(new Vector3(dir.x * colForce * factorGolp, dir.y * factorElev, dir.z * colForce * factorGolp), ForceMode.Impulse);

        }

    }

}
