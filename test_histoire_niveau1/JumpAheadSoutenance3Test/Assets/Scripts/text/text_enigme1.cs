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
			guitext.text = detection_language.text_language( "La porte que tu vois au loin est fermée.\nPour l'ouvrir tu devras récupérer les deux flammes de la damnation.\n(Cliquez pour continuer.)", "The door that you see faraway is closed.\nTo open it you should recover the two flames of the damnation.\n(click to continue.)");
			text1 = false;
		} else if (!text1 && text2 && (!flamme_pendule.activeSelf || !flamme_temple.activeSelf)) {
			guitext.gameObject.SetActive (true);
			guitext.GetComponent<text_level1>().set_start();
				guitext.text = detection_language.text_language( "Plus qu'une à récupérer.\n(Cliquez pour continuer.)", "There is only one more to recover.\n(click to continue.)");
			text2 = false;
		} else if (!text1 && !text2 && text3 &&(!flamme_pendule.activeSelf && !flamme_temple.activeSelf)) {
			guitext.gameObject.SetActive (true);
			guitext.GetComponent<text_level1>().set_start();
				guitext.text = detection_language.text_language( "La porte est maintenant ouverte.\nMaintenant , crois en toi et saute en direction de la porte.\n(Cliquez pour continuer.)", "The door is now opened.\nNow, believe in you and jump in direction of the door.\n(click to continue.)");
			text3 = false;
		}
	}
}
