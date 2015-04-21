using UnityEngine;
using System.Collections;



public class Change_Camera : MonoBehaviour
{
	public Camera first;
	public Camera third;
	public bool vue_first_perso;
	void Start()
	{
		first.gameObject.SetActive (vue_first_perso);
		third.gameObject.SetActive (!(vue_first_perso));
	}
}