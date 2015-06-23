using UnityEngine;
using System.Collections;

public class Pendules : MonoBehaviour {
	GameObject[] pendules;
	// Use this for initialization
	void Start () {
		pendules = GameObject.FindGameObjectsWithTag ("Pendule");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("azertyuiop");
		if (other.gameObject.tag == "Player") {
			foreach (var a in pendules) {
				Debug.Log("siqlgf");
				Rigidbody rb = a.GetComponent<Rigidbody>();
				rb.isKinematic = false;
			}
		}
	}
}
