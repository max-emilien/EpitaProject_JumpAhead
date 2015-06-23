using UnityEngine;
using System.Collections;

public class Scene_Changer : MonoBehaviour {
	public string scene_index;
	public void ChangeToScene (string scene_index)
	{
		Application.LoadLevel(scene_index);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
