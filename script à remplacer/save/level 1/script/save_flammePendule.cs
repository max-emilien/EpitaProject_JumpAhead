using UnityEngine;
using System.Collections;

public class save_flammePendule : MonoBehaviour
{
    // placer le prefab au niveau de la flamme avec les pendules
    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("flamme pendule", 1);
        this.gameObject.SetActive(false);
    }
}
