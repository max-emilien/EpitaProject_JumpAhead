using UnityEngine;
using System.Collections;

public class CharacterColision : MonoBehaviour {
	public int index_niveau_suivant;
	public GameObject plateforme_qui_tombe1;
	public GameObject plateforme_qui_tombe2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			if (Input.GetKeyDown (KeyCode.T)) {
				this.transform.position = new Vector3 (-5, 32, 81);
			}
		}
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
			if (other.gameObject.name == "TriggerPlateformeTombante1"){
				Debug.Log ("detection plateforme qui tombe 1");
			plateforme_qui_tombe1.rigidbody.isKinematic = false;
			plateforme_qui_tombe1.rigidbody.AddForce(new Vector3(0,1,0));
		}
			else if (other.gameObject.name == "TriggerPlateformeTombante2"){
				Debug.Log ("detection plateforme qui tombe 2");
				plateforme_qui_tombe2.rigidbody.isKinematic = false;
				plateforme_qui_tombe2.rigidbody.AddForce(new Vector3(0,1,0));
			}
	}
	}
}
