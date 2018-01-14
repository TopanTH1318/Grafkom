using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	//movemenr variables
	public float KecepatanX,kecepatanY,kecepatanZ;

	private Rigidbody2D myRB;
	private Animator myAnim;
	public bool facing, notfacing;
	SpriteRenderer sr;
	//public Vector2 power = new Vector2(0,1800);
	//private bool isJumping = false;
	// Use this for initialization

	// Use this for initialization
	void Start () {

		myRB = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();
		sr = gameObject.GetComponent<SpriteRenderer> ();
		facing = false;
	}

	void kanans(){
		facing = true;
	}

	void kiris(){
		facing = false;
	}
	//void Jump()
	//{
	//Jumping

	//	if (!isJumping)
	//	{
	//		GetComponent<Rigidbody2D>().AddForce(power);
	//		isJumping = true;
	//	}
	//}

	//private void OnCollisionStay2D(Collision2D collision)
	//{
	//	if (collision.transform.tag == "Ground")
	//		isJumping = false;
	//}

	void Update () {
		if (facing==true) {
			transform.Translate (-0.05f, kecepatanY, kecepatanZ);
			Vector2 position = transform.position;
			if (position.x >= 233.1544f) {
				facing = false;
				sr.flipX = false;
			}
		} else{
			transform.Translate (0.05f, kecepatanY, kecepatanZ);
			Vector2 position = transform.position;
			if (position.x <= 40.84f) {
				facing = true;
				sr.flipX = true;
			}
		}
	}
		

	// Update is called once per frame

}
