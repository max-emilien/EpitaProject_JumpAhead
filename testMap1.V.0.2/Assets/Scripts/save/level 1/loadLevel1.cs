using UnityEngine;
using System.Collections;

public class loadLevel1 : MonoBehaviour {
	public GameObject player;
	public GameObject checkpoint_1;
	public GameObject checkpoint_2;
	public GameObject checkpoint_3;
	// Use this for initialization
	void Start () {
		int checkpoint = PlayerPrefs.GetInt ("checkpoint", 0);
		int double_jump = PlayerPrefs.GetInt ("doublejump", 0);
		int flamme_temple = PlayerPrefs.GetInt ("flamme temple", 0);
		int flamme_pendule = PlayerPrefs.GetInt ("flamme pendule", 0);
		if (checkpoint != 0) {
			PersoRespawn pr = player.GetComponent<PersoRespawn>();
			if (checkpoint == 1) {
				pr.set_spawn( checkpoint_1.transform.position );
				//PersoRespawn.setspawn( chekpoint_1);
			} else if (checkpoint == 2) {
				pr.set_spawn( checkpoint_2.transform.position );
				// PersoRespawn.setspawn( chekpoint_2);
			} else if (checkpoint == 3) {
				pr.set_spawn( checkpoint_3.transform.position );
				// PersoRespawn.setspawn( chekpoint_3);
			} else {
				throw new UnityException ("sauvegarde corrompu");
			}
		}
		if (double_jump != 0) {
			if (double_jump == 1) {

				// set active bool doublejump_possible
			} else {
				throw new UnityException ("sauvegarde corrompu");
			}
		}
		if (flamme_temple != 0) {
			if (double_jump == 1) {
				// flamme_temple recuperee
			} else {
				throw new UnityException ("sauvegarde corrompu");
			}
		}
		if (double_jump != 0) {
			if (double_jump == 1) {
				// flamme_pendule recuperee
			} else {
				throw new UnityException ("sauvegarde corrompu");
			}
		}
	}
}
