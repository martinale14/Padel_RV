using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    private Vector3 offset;
    private GameObject raqueta;
    public Vector3 initialPos;
    // Start is called before the first frame update
    void Start()
    {
        raqueta = GameObject.Find("pala");
        initialPos = transform.parent.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Camera.main.transform.position;
        transform.LookAt(new Vector3(-pos.x , pos.y, pos.z));

        offset = transform.parent.position - raqueta.transform.position;

        float escala = (offset.magnitude/10)+0.5f;

        transform.localScale = new Vector3(1,1,1)*escala;
    
    }

    static public float Map(float value, float istart, float istop, float ostart, float ostop){

    return ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
    
}
}
