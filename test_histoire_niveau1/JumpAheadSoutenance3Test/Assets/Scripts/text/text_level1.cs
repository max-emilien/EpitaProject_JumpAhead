using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_level1 : MonoBehaviour {
	Text guitext;
	float start;
	void Start () 
	{
		guitext =  this.gameObject.GetComponent<Text> ();
		guitext.text  = "Voici la première épreuve à relever.\n(Cliquez pour continuer.)";
		start = Time.time;
	}
	void Update()
	{
		if ((Input.GetKey (KeyCode.Mouse0))&&(Time.time - 1 > start)) {
			gameObject.SetActive(false);
		}
	}
}
