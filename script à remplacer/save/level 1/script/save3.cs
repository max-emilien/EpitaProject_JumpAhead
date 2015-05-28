using UnityEngine;
using System.Collections;

public class save3 : MonoBehaviour {

	// placer le prefab au niveau du checkpoint 2
	void OnTriggerEnter(Collider other)
	{
		PlayerPrefs.SetInt ("checkpoint", 2);
	}
}
