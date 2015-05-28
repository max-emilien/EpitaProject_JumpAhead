using UnityEngine;
using System.Collections;

public class BallTrap : MonoBehaviour {
	//private GameObject[] crackedPf;
	//private Rigidbody[] rgCrackedPf;
	private GameObject ball;
	private Rigidbody rgBall;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find("Boule");
		rgBall = ball.GetComponent<Rigidbody>();
		rgBall.isKinematic = true;
	//	crackedPf = GameObject.FindGameObjectsWithTag ("CrackedRoof");
	//	for (int i = 0; i < crackedPf.Length; i++) {
	//		rgCrackedPf[i] = crackedPf[i].GetComponent<Rigidbody>();
	//	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			rgBall.isKinematic = false;
	//		for (int j = 0; j < rgCrackedPf.Length; j++) {
	//			rgCrackedPf[j].isKinematic = false;
	//		}
		}
	}
}
