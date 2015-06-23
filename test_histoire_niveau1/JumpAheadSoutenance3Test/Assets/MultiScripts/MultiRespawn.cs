using UnityEngine;
using System.Collections;

public class MultiRespawn : MonoBehaviour {
	private GameObject[] SpawnPoints;
	// Use this for initialization
	void Start () {
		SpawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
