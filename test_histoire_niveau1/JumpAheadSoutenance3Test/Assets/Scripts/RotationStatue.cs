using UnityEngine;
using System.Collections;

public class RotationStatue : MonoBehaviour {
	public float speed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate (Vector3.up * Time.deltaTime * speed,Space.World);
	}
}
