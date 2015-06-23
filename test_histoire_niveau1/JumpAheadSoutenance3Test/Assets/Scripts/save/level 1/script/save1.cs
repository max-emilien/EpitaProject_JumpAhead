using UnityEngine;
using System.Collections;

public class save1 : MonoBehaviour {

	// placer le prefab au niveau du spawn initial
	void OnTriggerEnter(Collider other)
	{
		PlayerPrefs.SetInt ("niveau", 1);
		PlayerPrefs.SetInt ("checkpoint", 0);
		PlayerPrefs.SetInt ("doublejump", 0);
		PlayerPrefs.SetInt ("flamme temple", 0);
		PlayerPrefs.SetInt ("flamme pendule", 0);
	}
}
