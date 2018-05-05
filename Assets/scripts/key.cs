using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
	public int f = 0;

	void OnTriggerEnter (Collider other)
	{
		if (f == 1) { controler.Key = true;
			gameObject.SetActive (false);
			print ("you pick up key1");
		}
		if (f == 2) {
			controler.Key2 = true;
			gameObject.SetActive (false);
			print ("you pick up key2");
		}
		if (f == 3) {
			controler.Key1 = true;
			gameObject.SetActive (false);
			print ("you pick up key3");
		}
		print (controler.health);
	}
}
