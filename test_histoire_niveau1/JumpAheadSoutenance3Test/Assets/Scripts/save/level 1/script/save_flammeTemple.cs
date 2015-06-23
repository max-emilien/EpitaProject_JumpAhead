using UnityEngine;
using System.Collections;

public class save_flammeTemple : MonoBehaviour {

    //placer le prefabs au niveau de la flamme du temple
    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("flamme temple", 1);
        this.gameObject.SetActive(false);
    }
}
