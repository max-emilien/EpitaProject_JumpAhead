using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_powerUp : MonoBehaviour {
	public Text guitext;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		guitext.gameObject.SetActive (true);
		guitext.text = "Voici un petit cadeau pour t'aider à continuer ton voyage.\n(Cliquez pour continuer.)";

	}
}
