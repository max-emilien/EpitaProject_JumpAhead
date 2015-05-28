using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	public GameObject cle1;
	public GameObject cle2;

	// Use this for initialization
	void Start () {
		//Rigidbody rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cle1.activeInHierarchy && cle2.activeInHierarchy) {
			Rigidbody rg = GetComponent<Rigidbody>();
			rg.isKinematic = false;
		}
	}
}
