using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_enigme1 : MonoBehaviour {
	public Text guitext;
	public GameObject flamme_temple;
	public GameObject flamme_pendule;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (flamme_pendule.activeSelf && flamme_temple.activeSelf) {
			guitext.gameObject.SetActive (true);
			guitext.text = "La porte que tu vois au loin est fermée.\nPour l'ouvrir tu devras récupérer les deux flammes de la damnation.\n(Cliquez pour continuer.)";

		} else if (flamme_pendule.activeSelf || flamme_temple.activeSelf) {
			guitext.gameObject.SetActive (true);
			guitext.text = "Plus qu'une à récupérer.\n(Cliquez pour continuer.)";
		} else {
			guitext.gameObject.SetActive (true);
			guitext.text = "La porte est maintenant ouverte.\nMaintenant , crois en toi et saute en direction de la porte.\n(Cliquez pour continuer.)";
		}
	}
}
