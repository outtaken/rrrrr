using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class terminator : MonoBehaviour {
	public Transform pointa;
	public Transform pointb;
	public Transform pointc;
	public Transform pointd;
	public int HP =1000;
	public GameObject e;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		agent.destination = pointb.position;
		e.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (agent.transform.position.x == pointc.position.x && agent.transform.position.z == pointa.position.z) {
			agent.SetDestination (pointa.position);
			print ("c");
		}
		if (agent.transform.position.x == pointa.position.x && agent.transform.position.z == pointb.position.z) {
			agent.SetDestination (pointb.position);
			print ("a");
		}
		if (HP==0){
			e.gameObject.SetActive (false);
		}
}
}