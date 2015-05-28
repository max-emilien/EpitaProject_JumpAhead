using UnityEngine;
using System.Collections;

public class PlateformeQuiTombe : MonoBehaviour {
	/*
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
	*/
	public GameObject target;
	public int fall = 0;

	void Start(){
	
	}

	IEnumerator OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			yield return new WaitForSeconds(fall);
			target.SetActive(false);
			yield return new WaitForSeconds(3);
			target.SetActive(true);
		}
	}
}
