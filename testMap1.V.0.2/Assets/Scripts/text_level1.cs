using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_level1 : MonoBehaviour {
	Text guitext;
	public GameObject perso;
	void Start () 
	{
		guitext =  this.gameObject.GetComponent<Text> ();
		changement_text ("Voici la première épreuve à relever.\n(Cliquez pour continuer.)");
	}
	void changement_text(string text)
	{
		guitext.text = text;

		//while (!Input.GetKey (KeyCode.Mouse0)) {

	}
}
