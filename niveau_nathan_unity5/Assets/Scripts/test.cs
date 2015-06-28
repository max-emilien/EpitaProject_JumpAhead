using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class test : MonoBehaviour {

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
		if (Input.anyKey) {
			if (Input.GetKey(KeyCode.T))
			{
				PlayerPrefs.SetInt("language", 0);
			}
			else if (Input.GetKey(KeyCode.Y))
			{
				PlayerPrefs.SetInt("language", 1);
			}
		}
	}
}
