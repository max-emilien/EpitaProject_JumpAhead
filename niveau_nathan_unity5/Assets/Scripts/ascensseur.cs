using UnityEngine;
using System.Collections;

public class ascensseur : MonoBehaviour {
	Transform positionA;
	Transform positionb;
	public int hauteur;
	// Use this for initialization
	void Start () {
		positionA.position = this.gameObject.transform.position;
		positionb.position = this.gameObject.transform.position + new Vector3 (0, hauteur, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate () {
		float weight = (float)(Mathf.Cos(Time.time * 2 * Mathf.PI) * 0.5 + 0.5);
		transform.position = positionA.position + positionb.position * (1-weight);
	}
}
