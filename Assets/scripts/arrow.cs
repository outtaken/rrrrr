using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {
	public GameObject Bullet;
	public Transform Spawn;
	public float speed=50.0f;
	public AudioSource sound;
	// Use this for initialization
	void Update () {
		if (Input.GetKeyUp (KeyCode.Mouse0)) {
			Fire ();
		}
	}
	
	// Update is called once per frame
	void Fire () {
		sound.Play ();
		var bullet = (GameObject)Instantiate (Bullet, Spawn.position, Spawn.rotation);
		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * speed;
		Destroy (bullet, 2.0f);
	}
}
