using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class yy : MonoBehaviour {
	public Image img;

	// Use this for initialization
	void Start () {
		img.gameObject.SetActive (false);
		
	}
	
	void OnTriggerEnter (Collider other){
		img.gameObject.SetActive (true);
	}
	void OnTriggerExit(Collider other){
		img.gameObject.SetActive (false);
	}
}
