using UnityEngine;
using System.Collections;

public class PlateformeQuiTombe : MonoBehaviour {
	public Rigidbody plateforme;
	// Use this for initialization
	void Start () {
		plateforme.isKinematic = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "player") {
			plateforme.isKinematic = true;
		}
	}
}
