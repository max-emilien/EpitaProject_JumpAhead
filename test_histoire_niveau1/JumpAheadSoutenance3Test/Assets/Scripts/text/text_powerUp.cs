using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_powerUp : MonoBehaviour {
	public Text guitext;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		guitext.gameObject.SetActive (true);
		guitext.GetComponent<text_level1>().set_start();
		guitext.text = detection_language.text_language( "Voici un petit cadeau pour t'aider à continuer ton voyage.\n(Cliquez pour continuer.)", "This is a little present to help you to continue your trip.\n(click to continue.)");
	}
}
