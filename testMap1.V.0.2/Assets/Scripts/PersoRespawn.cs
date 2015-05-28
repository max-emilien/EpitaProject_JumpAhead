using UnityEngine;
using System.Collections;

public class PersoRespawn : MonoBehaviour
{

    private Vector3 spawn;
    // Use this for initialization
    void Start()
    {
        spawn = new Vector3(25f, 2f, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WayPoints")
        {
            spawn = other.transform.position;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject, 5f);

        }
        if (other.gameObject.tag == "vide" || other.gameObject.tag == "Ennemy")
        {
            this.transform.position = spawn;
        }
    }
    public void set_spawn(Vector3 vect)
    {
        spawn = vect;
    }
}
