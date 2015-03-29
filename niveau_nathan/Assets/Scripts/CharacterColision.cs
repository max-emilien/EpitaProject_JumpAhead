using UnityEngine;
using System.Collections;

public class CharacterColision : MonoBehaviour {
	public int index_niveau_suivant;
	public GameObject plateforme_qui_tombe;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
				Debug.Log ("detection de triger");
				if (other.gameObject.tag == "vide") {
						Application.LoadLevel (Application.loadedLevel);
						//Debug.Log("vide detecte");
				} else if (other.gameObject.tag == "Finish") {
						//Debug.Log("détection fin niveau");
						Application.LoadLevel (index_niveau_suivant);
				} else if (other.gameObject.tag == "plateformeTombante") {
						Debug.Log ("detection plateforme qui tombe");
						plateforme_qui_tombe.rigidbody.isKinematic = false;
				} else if (other.gameObject.tag == "Ennemy") {
						//Debug.Log("détection de la boule");
						Application.LoadLevel (Application.loadedLevel);
				}
	}
}
