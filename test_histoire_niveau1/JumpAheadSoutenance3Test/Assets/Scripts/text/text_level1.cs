using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_level1 : MonoBehaviour {
	Text guitext;
	public GameObject perso;
	private UnityStandardAssets.Characters.FirstPerson.FirstPersonController2 script;
	float start;
	public float duree_text;
	void Start () 
	{
		guitext =  this.gameObject.GetComponent<Text> ();
		guitext.text  = "Voici la première épreuve à relever.\n(Cliquez pour continuer.)";
		start = Time.time;
		script = perso.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController2> ();
	}
	void Update()
	{
		if ((Time.time - duree_text > start)||(Input.GetKey(KeyCode.Mouse0))) {
			script.enabled = true;
			gameObject.SetActive (false);
		} else {
			script.enabled = !(script.perso_is_grouded());
		}
	}
	public void set_start()
	{
		start = Time.time;
	}
}
