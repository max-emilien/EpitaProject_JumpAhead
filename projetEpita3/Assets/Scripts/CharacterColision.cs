using UnityEngine;
using System.Collections;

public class CharacterColision : MonoBehaviour {
	public int index_niveau_suivant;
	public GameObject plateforme_qui_tombe;
	private Vector3 chekpoint;
	// Use this for initialization
	void Start () {
		if (chekpoint == new Vector3(0,0,0)) {
			chekpoint = this.transform.position;
				}
	
	}
	void OnTriggerEnter(Collider other)
	{
				Debug.Log ("detection de triger");
				if (other.gameObject.tag == "vide") {
			Debug.Log(this.transform.position);
						this.transform.position = chekpoint;
			Debug.Log(this.transform.position);
						//Application.LoadLevel (Application.loadedLevel);
						Debug.Log("vide detecte");
				} else if (other.gameObject.tag == "Finish") {
						//Debug.Log("détection fin niveau");
						chekpoint = new Vector3(0,0,0);
						Application.LoadLevel (index_niveau_suivant);
				} else if (other.gameObject.tag == "plateformeTombante") {
						Debug.Log ("detection plateforme qui tombe");
						plateforme_qui_tombe.rigidbody.isKinematic = false;
				} else if (other.gameObject.tag == "Ennemy") {
						//Debug.Log("détection de la boule");
						//Application.LoadLevel (Application.loadedLevel);
						this.transform.position = chekpoint;		
				} else if (other.gameObject.tag == "chekpoint") {
			Debug.Log("détection du chekpoint");
			chekpoint = other.transform.position;
				}
	}
}
