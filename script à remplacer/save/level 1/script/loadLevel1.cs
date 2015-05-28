using UnityEngine;
using System.Collections;

public class loadLevel1 : MonoBehaviour
{
    public GameObject player;
    public GameObject checkpoint_1;
    public GameObject checkpoint_2;
    public GameObject checkpoint_3;
    public GameObject objet_doubleJump;
    public GameObject save_spawn;
    public GameObject save_checkpoint1;
    public GameObject save_checkpoint2;
    public GameObject save_checkpoint3;
    public GameObject save_flammePendule;
    public GameObject flamme_Pendule1;
    public GameObject flamme_Pendule2;
    public GameObject save_flammeTemple;
    public GameObject flamme_Temple1;
    public GameObject flamme_Temple2;
    //placer le prefab n'importe ou sur la carte
    void Start()
    {
        if (PlayerPrefs.GetInt("niveau", 0) == 1)
        {
            int checkpoint = PlayerPrefs.GetInt("checkpoint", 0);
            int double_jump = PlayerPrefs.GetInt("doublejump", 0);
            int flamme_temple = PlayerPrefs.GetInt("flamme temple", 0);
            int flamme_pendule = PlayerPrefs.GetInt("flamme pendule", 0);
            if (checkpoint != 0)
            {
                PersoRespawn pr = player.GetComponent<PersoRespawn>();
                save_spawn.SetActive(false);
                if (checkpoint == 1)
                {
                    pr.set_spawn(checkpoint_1.transform.position);
                }
                else
                {
                    save_checkpoint1.SetActive(false);
                    if (checkpoint == 2)
                    {
                        pr.set_spawn(checkpoint_2.transform.position);
                    }
                    else
                    {
                        save_checkpoint2.SetActive(false);
                        if (checkpoint == 3)
                        {
                            pr.set_spawn(checkpoint_3.transform.position);
                            save_checkpoint3.SetActive(false);
                        }
                        else
                        {
                            throw new UnityException("sauvegarde corrompu");
                        }
                    }
                }
            }
            if (double_jump != 0)
            {
                if (double_jump == 1)
                {
                    player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController2>().possibility_DoubleJump = true;
                    objet_doubleJump.gameObject.SetActive(false);
                }
                else
                {
                    throw new UnityException("sauvegarde corrompu");
                }
            }
            if (flamme_temple != 0)
            {
                if (double_jump == 1)
                {
                    flamme_Temple1.SetActive(false);
                    flamme_Temple2.SetActive(true);
                }
                else
                {
                    throw new UnityException("sauvegarde corrompu");
                }
            }
            if (flamme_pendule != 0)
            {
                if (flamme_pendule == 1)
                {
                    flamme_Pendule1.SetActive(false);
                    flamme_Pendule2.SetActive(true);
                }
                else
                {
                    throw new UnityException("sauvegarde corrompu");
                }
            }
        }
        this.gameObject.SetActive(false);
    }
}
