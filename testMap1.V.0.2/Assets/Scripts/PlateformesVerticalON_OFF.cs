using UnityEngine;
using System.Collections;

public class PlateformesVerticalON_OFF : MonoBehaviour {
	private GameObject[] plateFormes;
	//public bool statement;
	// Use this for initialization
	void Start () {
		plateFormes = GameObject.FindGameObjectsWithTag ("PlateformeVerticaleMoving");
		foreach (GameObject pf in plateFormes) {
			pf.isStatic = true;
		}
	//	statement = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
	//		statement = true;
			foreach (GameObject pf in plateFormes) {
				pf.isStatic = false;
			}
		}
	}
}
