using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Rigidbody rb;
	public GameObject bullet;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMovement = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (horizontalMovement, 0.0f, 0);
		
		rb.velocity = speed * movement;

		if (Input.GetButtonDown ("Jump")) {
			Instantiate (bullet, firePoint.position, Quaternion.identity);
		}
	}
}
