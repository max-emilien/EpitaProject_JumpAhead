using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	GameObject[] _spawnPoints;
	public Camera camObs;
	// Use this for initialization
	void Start () {
		_spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		Connect ();
	}
	void Connect(){
		PhotonNetwork.ConnectUsingSettings ("JumpAheadMultiPlayerAlpha");
	}

	void OnGUI(){
		GUILayout.Label ( PhotonNetwork.connectionStateDetailed.ToString() );
	}

	void OnJoinedLobby(){
		Debug.Log ("OnJoinedLobby");
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed(){
		Debug.Log ("OnPhotonRandomJoinFailed");
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom(){
		Debug.Log ("OnJoinedRoom");
		SpawnPlayer ();
	}

	void SpawnPlayer(){
		if (_spawnPoints == null) {
			Debug.LogError("No Spawning areas");
		}
		Vector3 _spawnPlayer = _spawnPoints [Random.Range (0, _spawnPoints.Length)].transform.position;
		camObs.enabled = false;
		GameObject player = PhotonNetwork.Instantiate ("MultiPlayer",_spawnPlayer,Quaternion.identity, 0); 
		((MonoBehaviour)player.GetComponent ("FirstPersonController2")).enabled = true;
		player.transform.FindChild ("FirstPersonCharacter").gameObject.SetActive (true);
	}
}
