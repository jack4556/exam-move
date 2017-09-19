using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && grounded == true) {
			rigidbody2D.AddForce(transform.up*jumpPower);
			grounded = false;
		
	}
}
}
