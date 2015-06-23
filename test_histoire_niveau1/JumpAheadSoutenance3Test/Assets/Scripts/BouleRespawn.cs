using UnityEngine;
using System.Collections;

public class BouleRespawn : MonoBehaviour {
	private Vector3 originPosition; 
	// Use this for initialization
	void Start () {
		//GameObject ball = GameObject.Find ("Boule");
		originPosition = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "vide") {
			this.gameObject.transform.position = originPosition;
			Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
			rb.isKinematic = true;
		}
	}
}
