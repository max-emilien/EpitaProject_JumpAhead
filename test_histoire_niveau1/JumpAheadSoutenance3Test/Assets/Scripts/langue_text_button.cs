using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class langue_text_button : MonoBehaviour
{
    public Text guitext;
    public string fr_phrase;
    public string en_sentence;

    public void Update()
    {
        if (PlayerPrefs.GetInt("language", 0) == 0)
        {
            guitext.text = fr_phrase;
        }
        else
        {
            guitext.text = en_sentence;
        }
    }
}
