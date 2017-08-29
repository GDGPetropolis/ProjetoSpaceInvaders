using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float Speed = 0;
	public float HorizontalMovement = 0;
	public GameObject bullet;
	public Transform firePoint;
	public Rigidbody rb;
	// Use this for initialization
	public float FireRate;
	private float CurrentTime;

	void Start () {
		FireRate = Random.Range (3, 7);
	}
	
	// Update is called once per frame
	void Update () {
		CurrentTime += Time.deltaTime;
		if(CurrentTime >= FireRate){
			CurrentTime = 0;
			Instantiate (bullet, firePoint.position, Quaternion.identity);
		}

		Vector3 movement = new Vector3 (this.HorizontalMovement, 0.0f, 0);

		rb.velocity = this.Speed * movement;		
	}

	void OnCollisionEnter(Collision other){
		Speed = Speed * -1;
		}
	}
