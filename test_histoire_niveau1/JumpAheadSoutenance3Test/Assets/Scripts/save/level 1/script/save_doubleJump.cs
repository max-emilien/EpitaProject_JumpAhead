using UnityEngine;
using System.Collections;

public class save_doubleJump : MonoBehaviour {

    //placer le prefab au niveau de la statue du double jump
    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("doublejump", 1);
        this.gameObject.SetActive(false);
    }
}
