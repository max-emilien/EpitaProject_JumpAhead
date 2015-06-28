using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class langue_text_texture : MonoBehaviour
{
    public Image image;
	public Sprite fr_Sprite;
	public Sprite en_Sprite;

    public void Update()
    {
        if (PlayerPrefs.GetInt("language", 0) == 0)
        {
			image.sprite = fr_Sprite;
        }
        else
        {
			image.sprite = en_Sprite;
        }
    }
}
