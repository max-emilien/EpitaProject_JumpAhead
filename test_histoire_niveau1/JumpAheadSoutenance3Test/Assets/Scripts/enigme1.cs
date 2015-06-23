using UnityEngine;
using System.Collections;

public class enigme1 : MonoBehaviour {
	public GameObject flame;
	public GameObject key;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			flame.SetActive(false);
			key.gameObject.SetActive(true);
		}
	}
}
