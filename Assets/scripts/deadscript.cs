using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class deadscript : MonoBehaviour {
	public GameObject w;
	// Use this for initialization
	void Start () {
		w.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(controler.health <=0){
			w.SetActive (true);
		}
	}
	public void RestartBtn(){
		w.SetActive (false);
		controler.health += 100;
		SceneManager.LoadScene ("уч5",LoadSceneMode.Single);
	}
}

