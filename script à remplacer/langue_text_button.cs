using UnityEngine;
using System.Collections;

public class langue_text_button
{
    public Text guitext;
    public string fr_phrase;
    public string en_sentence;

    public void Start()
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
