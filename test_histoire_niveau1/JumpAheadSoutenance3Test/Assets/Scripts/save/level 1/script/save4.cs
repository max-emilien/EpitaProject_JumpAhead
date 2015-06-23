using UnityEngine;
using System.Collections;

public class save4 : MonoBehaviour {

	// placer le prefab au niveau du checkpoint 3
	void OnTriggerEnter(Collider other)
	{
		PlayerPrefs.SetInt ("checkpoint", 3);
        this.gameObject.SetActive(false);
	}
}
