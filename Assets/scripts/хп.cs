using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class хп : MonoBehaviour {
	public Text Healthtxt;

	// Use this for initialization
	void Start () {
		Healthtxt.text= controler.health.ToString();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Healthtxt.text= controler.health.ToString();
	}
}
