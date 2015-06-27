using UnityEngine;
using System.Collections;

public class detection_language {
	// Use this for initialization
	public static string text_language(string francais, string english)
	{
		if (PlayerPrefs.GetInt ("language", 0) == 0) {
			return francais;
		} else {
			return english;
		}
	}
    public static string text_language(bool booleen)
    {
        if (PlayerPrefs.GetInt("language", 0) == 0)
        {
            if (booleen)
            {
                return "vrai";
            }
            else
            {
                return "faux";
            }
        }
        else
        {
            return booleen.ToString();
        }
    }
    public static void set_fr()
    {
        PlayerPrefs.SetInt("language", 0);
    }
    public static void set_en()
    {
        PlayerPrefs.SetInt("language", 1);
    }
}
