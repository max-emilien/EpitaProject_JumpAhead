using UnityEngine;
using System.Collections;

public class PersoRespawn : MonoBehaviour {

	public Vector3 Pos;
	public Transform Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter(Collider other){
		if (other.transform == Player) {
			Player.transform.position = new Vector3(25f,2f,10f);
		}
		else {
			Player.transform.position = Pos;
		}
	}
}
