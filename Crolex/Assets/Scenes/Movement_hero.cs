using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_hero : MonoBehaviour {

    Rigidbody2D rb;
    private float inse = 3f;
	// Use this for initialization 
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(inse, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (inse < 20f)
        {
            inse += 0.03f;
            rb.velocity = new Vector3(inse, 0, 0);
        }
        else
            rb.velocity = new Vector3(inse, 0, 0);
    }
}
