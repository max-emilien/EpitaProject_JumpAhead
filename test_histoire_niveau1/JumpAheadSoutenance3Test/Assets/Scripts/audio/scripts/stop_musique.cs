using UnityEngine;
using System.Collections;

public class stop_musique : MonoBehaviour {
	public GameObject main_musique;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			main_musique.GetComponent<Start_level>().Stop();
		}
	}
}
