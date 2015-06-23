using UnityEngine;
using System.Collections;

public class save2 : MonoBehaviour {

	// placer le prefab au niveau du checkpoint 1
	void OnTriggerEnter(Collider other)
	{
		PlayerPrefs.SetInt ("checkpoint", 1);
	}
}
