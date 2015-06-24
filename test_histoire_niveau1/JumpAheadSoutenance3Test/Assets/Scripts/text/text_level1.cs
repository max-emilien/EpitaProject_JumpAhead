using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_level1 : MonoBehaviour {
	Text guitext;
	public GameObject perso;
	float start;
	public float duree_text;
	void Start () 
	{
		guitext =  this.gameObject.GetComponent<Text> ();
		guitext.text  = "Voici la première épreuve à relever.\n(Cliquez pour continuer.)";
		start = Time.time;
	}
	void Update()
	{
		if (Time.time - duree_text > start) {
			perso.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController2>().enabled = true;
			gameObject.SetActive (false);
		} else {
			perso.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController2>().enabled = false;
		}
	}
	public void set_start()
	{
		start = Time.time;
	}
}
