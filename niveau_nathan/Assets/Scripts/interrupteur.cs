using UnityEngine;
using System.Collections;

public class interrupteur : MonoBehaviour {
	public GameObject objetActivable;
	bool active;

	void Start () {
		active = true;
	}
	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("colision detecter");
		if (other.gameObject.tag == "Player"){
			Debug.Log("colision détécté avec player");
			//animation.Play();
			this.gameObject.SetActive ( false);
			objetActivable.SetActive (true);
		} 
	}
}
