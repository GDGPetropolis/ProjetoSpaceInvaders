using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float speed = 0;
	public bool	isEnemy;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0, this.speed/100, 0);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			if (isEnemy == false) {
				Destroy (other.gameObject);
				Destroy (gameObject);
			}
		} 
		if (other.tag == "Player") {
			if (isEnemy == true) {
				Destroy (other.gameObject);
				Destroy (gameObject);
			}
		}

	}






}
