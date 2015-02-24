using UnityEngine;
using System.Collections;

public class CharacterColision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "plateformePiege") {
			other.gameObject.SetActive (false);
		} 
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "vide") {
			Application.LoadLevel(Application.loadedLevel);
				}
	}
}
