﻿using UnityEngine;
using System.Collections;

public class Personnage1 : MonoBehaviour {
	//private bool auSol;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		}
	void FixedUpdate () {
		
		float mouveHorizontal = Input.GetAxis("Horizontal");
		float mouveVertical = Input.GetAxis("Vertical");
		
		Vector3 mouvment = new Vector3(mouveHorizontal, 0, mouveVertical);
		rigidbody.AddForce(mouvment  * 500 * Time.deltaTime);
		if /*(*/(Input.GetKeyDown (KeyCode.Space))/*&&(auSol))*/ {
			Vector3 mouvement = new Vector3(0, 20000, 0);
			rigidbody.AddForce(mouvement  * Time.deltaTime);
			//auSol = false;
				}
		
	}

	/*void OnCollisionrEnter()
	{
		auSol = true;
	}*/

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "vide")
		{
			Application.LoadLevel(0);
		}
	}
}