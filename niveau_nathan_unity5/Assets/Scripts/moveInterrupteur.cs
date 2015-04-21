using UnityEngine;
using System.Collections;

public class moveInterrupteur : MonoBehaviour {
	public GameObject objetActivable;

	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("colision detecter");
		if (other.gameObject.tag == "Player"){
			Debug.Log("colision détécté avec player");
			this.GetComponent<Rigidbody>().isKinematic = true;
			while (this.gameObject.transform.localScale.y >0.1)
			{
				this.gameObject.transform.localScale = new Vector3(0,((float)(0.1*Time.deltaTime)),0);
				this.gameObject.transform.position = new Vector3(0,((float)(0.05*Time.deltaTime)),0);
			}
			this.gameObject.SetActive (false);
			objetActivable.SetActive (true);
		} 
	}
}
