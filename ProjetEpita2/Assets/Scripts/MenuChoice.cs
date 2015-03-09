using UnityEngine;
using System.Collections;

public class MenuChoice : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application.LoadLevel (level);
	}
}
