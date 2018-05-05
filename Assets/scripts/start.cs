using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class start : MonoBehaviour {
	
	void Start () {
		
	}
	public void RestartBtn(){

		SceneManager.LoadScene ("уч5",LoadSceneMode.Single);
	}
}
