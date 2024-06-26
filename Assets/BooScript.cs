using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BooScript : MonoBehaviour
{

    public Rigidbody2D boo;
    public float flightStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)== true){

            boo.velocity = Vector2.up * flightStrength;
        }
            
    }
}
