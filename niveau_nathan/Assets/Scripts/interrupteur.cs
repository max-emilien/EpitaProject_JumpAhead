using UnityEngine;
using System.Collections;

public class interrupteur : MonoBehaviour {
	public GameObject objetActivable;
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("colision detecter");
		if (other.gameObject.tag == "Player"){
			Debug.Log("colision détécté avec player");
			//this.animation.Play("activation interrupteur");
			this.gameObject.SetActive (false);
			objetActivable.SetActive (true);
		} 
	}
}
