using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
private Rigidbody rigidbola;
private Vector3 speed;
private float xdirection;
private float zdirection;


    // Start is called before the first frame update

    void Start()
    {
        rigidbola = GetComponent<Rigidbody>();
        xdirection = Random.Range(-4,4);
        while(xdirection == 0)
            {
            xdirection = Random.Range(-4,4);    
            }
        zdirection = Random.Range(-4,4);
        while(zdirection==0)
            {
            zdirection = Random.Range(-4,4);
            }
        speed = new Vector3(xdirection,0,zdirection);
        rigidbola.velocity = speed;
    }

    void movementBola()
    {
        rigidbola = GetComponent<Rigidbody>();
        xdirection = Random.Range(-4,4);
        while(xdirection == 0)
            {
            xdirection = Random.Range(-4,4);    
            }
        zdirection = Random.Range(-4,4);
        while(zdirection==0)
            {
            zdirection = Random.Range(-4,4);
            }
        speed = new Vector3(xdirection,0,zdirection);
        rigidbola.velocity = speed;
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
}
