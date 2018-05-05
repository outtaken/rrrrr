using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpadder : MonoBehaviour {
	

	void OnTriggerEnter (Collider other)
	{
		
		if (controler.health < 100) {
			controler.health += 10;
			print ("hp resumed");
		} else {
			print ("hp is full");
		}

	}
}
