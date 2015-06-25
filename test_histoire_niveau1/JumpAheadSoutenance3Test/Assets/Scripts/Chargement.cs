using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Chargement : MonoBehaviour {
	private float percentageLoaded;
	public string level;
	public Text guitext;
	public GameObject parent;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		percentageLoaded = Application.GetStreamProgressForLevel(level);
		if ((percentageLoaded != 0)&&(percentageLoaded != 1)) {
			guitext.text = (percentageLoaded * 100).ToString ();
		}

	}

	public void ChangeToScene (string scene_name)
	{
		level = scene_name;
		DontDestroyOnLoad (this);
		DontDestroyOnLoad (guitext);
		Application.LoadLevel (scene_name);
		Destroy (guitext);
		Destroy (this);
	}
	/*
	 var percentageLoaded : float = 0;
	
	var guiText: GUIText;
    
    
    function Start() {
    	guiText = GetComponent.<GUIText>();
    }
    
	function Update() {
		if(Application.GetStreamProgressForLevel(1) == 1) {
			guiText.text = "Level at index 1 has been fully streamed!";
		} else {
			percentageLoaded = Application.GetStreamProgressForLevel(1) * 100;
			guiText.text = percentageLoaded.ToString();
		}
	}
	 */
}
