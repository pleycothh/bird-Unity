using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridScript : MonoBehaviour
{
    public Rigidbody2D rb = new Rigidbody2D();
    public float flapStrength = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * flapStrength;
        }
    }
}
