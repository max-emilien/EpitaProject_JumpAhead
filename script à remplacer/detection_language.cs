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
    public static void set_fr()
    {
        PlayerPrefs.SetInt("language", 0);
    }
    public static void set_en()
    {
        PlayerPrefs.SetInt("language", 1);
    }
}
