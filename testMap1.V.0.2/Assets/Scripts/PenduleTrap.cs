using UnityEngine;
using System.Collections;

public class PenduleTrap : MonoBehaviour {
	private GameObject[] pendules;
	// Use this for initialization
	void Start () {
		pendules = GameObject.FindGameObjectsWithTag ("Pendule");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			foreach (var a in pendules) {
				Rigidbody rb = a.GetComponent<Rigidbody>();
				rb.isKinematic = false;
			}
		}
	}
}
