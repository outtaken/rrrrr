using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capcan1 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		controler.health -= 10;
		print ("run away");
}
}