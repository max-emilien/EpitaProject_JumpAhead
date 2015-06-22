using UnityEngine;
using System.Collections;

public class suiviPlateformeMouvante : MonoBehaviour {
	private Transform precedant;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "plateformeMouvante") {
			precedant = other.gameObject.transform;
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "plateformeMouvante") {
			this.transform.position = this.transform.position + (other.gameObject.transform.position - precedant.position);
			precedant = other.gameObject.transform;
		}
	}
}
