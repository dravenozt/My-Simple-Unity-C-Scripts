using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   
    [SerializeField] float rotation;
    [SerializeField] float rotationfactor;
    [SerializeField] float goFactor;
    // Start is called before the first frame update
    void Start()
    {
        goFactor= 10f;
        rotationfactor=200f;
    }

    // Update is called once per frame
    void Update()
    {
        float go = Input.GetAxis("Vertical");
        float rotate= Input.GetAxis("Horizontal");

        float goFinal=go*goFactor*Time.deltaTime ;

        rotation= -rotate*Time.deltaTime*rotationfactor;
        transform.Translate(0,goFinal,0);
        transform.Rotate(0,0,rotation);
        
    }
}
