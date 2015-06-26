using UnityEngine;
using System.Collections;

public class lancement_musique : MonoBehaviour {
	public GameObject main_musique;
	public AudioClip musique;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			main_musique.GetComponent<AudioSource> ().clip = musique;
			main_musique.GetComponent<Start_level>().Play();
		}
	}
}
