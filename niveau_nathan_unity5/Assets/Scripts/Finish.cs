using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	public int next_level;
	void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel (next_level);
	}
}
