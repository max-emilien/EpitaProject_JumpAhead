using UnityEngine;
using System.Collections;

public class ChargeTime : MonoBehaviour {
	public float barDisplay = 0f;
	//public float ratioX = 0.5f;
	//public float ratioY = 0.1f;
	public Vector2 size = new Vector2(60,20);
	public Texture2D empty;
	public Texture2D full;
	public string level;
	// Use this for initialization
	private float start;
	void Start () {
		start = Time.time;
		barDisplay = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (barDisplay < 0.5f) {
			barDisplay = barDisplay + 0.5f * Time.deltaTime;
		} else if (barDisplay < 0.7) {
			barDisplay = barDisplay + 0.25f * Time.deltaTime;
		} else if (barDisplay < 1) {
			barDisplay = barDisplay + 1f * Time.deltaTime;
		} else {

			Application.LoadLevel (level);
		}
	}

	void OnGUI(){
		GUI.BeginGroup (new Rect ((Screen.width / 2) - (Screen.width / 4), (Screen.height / 2) - (0.1f * Screen.height ), Screen.width / 2, Screen.height * 0.12f));
		GUI.Box (new Rect (0, 0, Screen.width /2 , Screen.height * 0.2f ), empty);
		
		// draw the filled-in part:
		GUI.BeginGroup (new Rect (0, 0, Screen.width / 2 * barDisplay, Screen.height * 0.12f));
		GUI.Box (new Rect (0, 0, Screen.width / 2, Screen.height * 0.2f), full);
		GUI.EndGroup ();
		
		GUI.EndGroup ();
	}
	public void setLevelName(string name)
	{
		level = name;
	}
	/*GUI.BeginGroup (new Rect (Scree, pos.y, size.x, size.y));
         GUI.Box (Rect (0,0, size.x, size.y),progressBarEmpty);
 
         // draw the filled-in part:
         GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
             GUI.Box (Rect (0,0, size.x, size.y),progressBarFull);
         GUI.EndGroup ();
 
     GUI.EndGroup ();
     */
}
