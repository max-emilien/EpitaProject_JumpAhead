using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 10f;
	public float jumpSpeed = 6f;
	public float fallTolerance = 0.5f;
	public float walkSpeed = 7f;

	Vector3 direction = Vector3.zero;
	float verticalvelocity = 0;
	bool doubleJump = false;

	CharacterController cc;
	Animator anim;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		direction = transform.rotation * new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		if (direction.magnitude > 1f) {
			direction = direction.normalized;
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			anim.SetFloat ("Speed", direction.magnitude/10f);
		}
		else {
			anim.SetFloat ("Speed", direction.magnitude);
		}

		Debug.Log (direction.magnitude);

		if (cc.isGrounded && Input.GetButton("Jump")) {
			verticalvelocity = jumpSpeed;
			//////////////////////////
			if (!cc.isGrounded && Input.GetButtonDown("Jump")) {
				verticalvelocity += jumpSpeed;
				doubleJump = true;
			}
			//////////////////////////
		}
	}

	void FixedUpdate(){
		Vector3 dist = new Vector3 ();

		if (Input.GetKey(KeyCode.LeftShift)) {
			dist = direction * walkSpeed * Time.deltaTime;
		}
	    else {
			dist = direction * speed * Time.deltaTime;	
		} 

		if (cc.isGrounded && verticalvelocity < 0) {
			//anim.SetBool("Jumping",false);
			//anim.SetTrigger("J");
			verticalvelocity = Physics.gravity.y * Time.deltaTime;
		}
		else {
			if (Mathf.Abs (verticalvelocity) > jumpSpeed * fallTolerance) {
				//anim.SetBool("Jumping", true);
				anim.SetTrigger("J");
				if (doubleJump) {
					anim.SetBool("DoubleJumping", true);
				}
			}

			verticalvelocity += Physics.gravity.y * Time.deltaTime;
		}

		dist.y = verticalvelocity * Time.deltaTime;

		cc.Move (dist);
	}
}
