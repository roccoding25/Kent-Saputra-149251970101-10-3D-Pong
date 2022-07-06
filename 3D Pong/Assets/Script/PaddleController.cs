using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
public int speed;
public KeyCode upKey; 
public KeyCode downKey;

public KeyCode leftKey; 
public KeyCode rightKey;
private Rigidbody rb;

public bool player1,player2,player3,player4;
 
    private void Start() 
    { 
        rb = GetComponent<Rigidbody>();
    } 
 
    private void Update() 
    { 
        // get input 
        Vector3 movement = GetInput(); 
         
        // move object 
        MoveObject(movement); 
    } 
 
    private Vector3 GetInput() 
    { 
        if (Input.GetKey(upKey)) 
        { 
            return Vector3.forward * speed; 
        } 
        else if (Input.GetKey(downKey)) 
        { 
            return Vector3.back * speed; 
        }
        if (Input.GetKey(leftKey)) 
        { 
            return Vector3.left * speed; 
        } 
        else if (Input.GetKey(rightKey)) 
        { 
            return Vector3.right * speed; 
        }  
         
        return Vector3.zero;
    } 
 
    private void MoveObject(Vector3 movement) 
    { 
        Debug.Log("TEST: " + movement); 
        rb.velocity = movement; 
    } 
}
