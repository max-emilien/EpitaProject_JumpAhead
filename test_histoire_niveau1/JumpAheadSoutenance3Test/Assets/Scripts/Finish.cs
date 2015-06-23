using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	public int next_level;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel (next_level);
		}
	}
}
