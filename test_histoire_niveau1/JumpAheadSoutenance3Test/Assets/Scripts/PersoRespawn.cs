using UnityEngine;
using System.Collections;

public class PersoRespawn : MonoBehaviour {

	private Vector3 spawn;
	// Use this for initialization
	void Start () {
		spawn = new Vector3 (25f,2f,10f);
		this.gameObject.transform.position = spawn;
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "WayPoints") {
			spawn = other.transform.position;
			if (other.gameObject.name != "WayPoint3")
			{
				other.gameObject.SetActive(false);
			}

			//Destroy(other.gameObject, 5f);

		}
		if (other.gameObject.tag == "vide" || other.gameObject.tag == "Ennemy" || other.gameObject.tag == "Pendule") {
			this.transform.position = spawn;
		}
	}
	public void set_spawn(Vector3 vect)
	{
		spawn = vect;
	}
}
