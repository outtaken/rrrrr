using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horor : MonoBehaviour {


		IEnumerator MyMethod() {
			Debug.Log("Before Waiting 2 seconds");
			yield return new WaitForSeconds(2);
			Debug.Log("After Waiting 2 Seconds");
		controler.health -= 50;
			print ("gg");}
	
}
