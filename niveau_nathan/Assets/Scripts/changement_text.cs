using UnityEngine;
using System.Collections;

public class changement_text : MonoBehaviour {
	public GUIText case_text;
	public string text;
	// Use this for initialization
	void OnCollisionEnter()
	{
		case_text.text = text;
	}
}
