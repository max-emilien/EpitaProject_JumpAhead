using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_enigme1 : MonoBehaviour {
	public Text guitext;
	public GameObject flamme_temple;
	public GameObject flamme_pendule;
	public bool text1;
	public bool text2;
	public bool text3;
// Use this for initialization
	void Start()
	{
		text1 = true;
		text2 = true;
		text3 = true;
	}
	void OnTriggerEnter(Collider other)
	{
		if (text1 && (flamme_pendule.activeSelf && flamme_temple.activeSelf)) {
			guitext.gameObject.SetActive (true);
			guitext.GetComponent<text_level1>().set_start();
			guitext.text = "La porte que tu vois au loin est fermée.\nPour l'ouvrir tu devras récupérer les deux flammes de la damnation.\n(Cliquez pour continuer.)";
			text1 = false;
		} else if (!text1 && text2 && (!flamme_pendule.activeSelf || !flamme_temple.activeSelf)) {
			guitext.gameObject.SetActive (true);
			guitext.GetComponent<text_level1>().set_start();
			guitext.text = "Plus qu'une à récupérer.\n(Cliquez pour continuer.)";
			text2 = false;
		} else if (!text1 && !text2 && text3 &&(!flamme_pendule.activeSelf && !flamme_temple.activeSelf)) {
			guitext.gameObject.SetActive (true);
			guitext.GetComponent<text_level1>().set_start();
			guitext.text = "La porte est maintenant ouverte.\nMaintenant , crois en toi et saute en direction de la porte.\n(Cliquez pour continuer.)";
			text3 = false;
		}
	}
}
