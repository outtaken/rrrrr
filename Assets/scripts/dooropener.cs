using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropener : MonoBehaviour {
	public int q = 0;

	void OnTriggerEnter (Collider other){
		if	( controler.Key = true && q ==3){
			gameObject.SetActive (false);
		}
		else if	(controler.Key1 = true && q==1){
			gameObject.SetActive (false);
		}
	else	if	(controler.Key2 = true && q==2){
			gameObject.SetActive (false);
		}
	}

}
