using UnityEngine;
using System.Collections;

public class changementMode : MonoBehaviour {
	public GameObject persoFPS;
	public GameObject persoTPS;
	public bool modeFPS = true;
    void Start()
    {
        persoFPS.SetActive(mode);
        persoTPS.SetActive(!mode);
    }
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.F)) {
			mode = !mode;
			persoFPS.SetActive( mode);
			persoTPS.SetActive ( !mode);
            if (mode)
            {
                persoFPS.transform.position = persoTPS.transform.position;
                persoFPS.transform.rotation = persoTPS.transform.rotation;
            }
            else
            {
                persoTPS.transform.position = persoPPS.transform.position;
                persoFPS.transform.rotation = persoTPS.transform.rotation;
            }
		}
	}
}
