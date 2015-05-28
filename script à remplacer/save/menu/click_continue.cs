using UnityEngine;
using System.Collections;

public class click_continue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log ("bouton cliqué");
		if (PlayerPrefs.GetInt ("niveau", 0) == 1) {
			//Debug.Log ("niveau récupéré");
			//Cursor.visible = false;
			Application.LoadLevel (1);
			//Cursor.visible = true;
		} else {
			Debug.Log("niveau non récupéré");
		}
	}
}
