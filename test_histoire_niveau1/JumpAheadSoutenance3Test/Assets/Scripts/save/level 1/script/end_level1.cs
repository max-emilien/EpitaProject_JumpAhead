using UnityEngine;
using System.Collections;

public class end_level1 : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		PlayerPrefs.SetInt ("niveau", 2);
		PlayerPrefs.DeleteKey ("checkpoint");
		PlayerPrefs.DeleteKey ("doublejump");
		PlayerPrefs.DeleteKey ("flamme temple");
		PlayerPrefs.DeleteKey ("flamme pendule");
	}
}
