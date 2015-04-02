using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changement_text : MonoBehaviour {
	public Text case_text;
	public string text;
	// Use this for initialization
	void OnTriggerEnter()
	{
		case_text.text = text;
	}
}
