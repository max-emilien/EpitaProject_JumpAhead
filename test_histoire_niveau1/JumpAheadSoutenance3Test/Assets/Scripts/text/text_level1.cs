using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class text_level1 : MonoBehaviour {
	Text guitext;
	public string textWanted;
	void Start () 
	{
		guitext =  this.gameObject.GetComponent<Text> ();
		textWanted  = "Voici la première épreuve à relever.\n(Cliquez pour continuer.)";
	}
	void Update()
	{
		guitext.text = textWanted;
		if (Input.GetKey (KeyCode.Mouse0)) {
			gameObject.SetActive(false);
		}
	}
}
