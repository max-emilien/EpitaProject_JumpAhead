using UnityEngine;
using System.Collections;

public class MovingPlateformVerticaly : MonoBehaviour {
	//public float time;
	public float width;
	public float speed;
	//private GameObject player;
	private float multiplexer = 1.2f;
	private Vector3 moveUp;
	private Vector3 moveDown;
	private float y_origin;
	private bool reverseTime;
	//private float inverse;
	//private bool startMove;
	// Use this for initialization
	void Start () {
		y_origin = this.gameObject.transform.position.y;
		//lastTime = actualTime;
		reverseTime = false;
		//inverse = -1;
		moveUp = new Vector3 (0,speed*multiplexer*Time.deltaTime,0);
		moveDown = -moveUp;
		//startMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.gameObject.isStatic) {
			if (this.gameObject.transform.position.y <= y_origin - width || this.gameObject.transform.position.y >= y_origin + width) {
				reverseTime = (!reverseTime);
			}
			if (reverseTime) {
				this.gameObject.transform.Translate(moveUp,Space.World);
			}
			else {
				this.gameObject.transform.Translate(moveDown,Space.World);
			}
		}
	}

	float AbsoluteValue(float n){
		if (n<0) {
			n = -n;
		}
		return n;
	}
}
