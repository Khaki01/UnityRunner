using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_bg : MonoBehaviour {


    private Rigidbody2D rb2d;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity= new Vector2(-1.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
