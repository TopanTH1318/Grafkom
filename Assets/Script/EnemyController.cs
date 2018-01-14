using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	//movemenr variables
	public float Kecepatan = 10;

	private Rigidbody2D myRB;
	private Animator myAnim;
	private float moveX;
	public bool facing;
	//public Vector2 power = new Vector2(0,1800);
	//private bool isJumping = false;
	// Use this for initialization

	// Use this for initialization
	void Start () {

		myRB = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();

		facing = true;

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
	}
		

	// Update is called once per frame
	void FixedUpdate () {

		//check if we are grounded - if no we are falling
		//myAnim.SetBool ("isGrounded", grounded);

		//myAnim.SetFloat("verticalSpeed",myRB.velocity.y);

		//moveX = Input.GetAxis ("Horizontal");
		//myAnim.SetFloat("Speed",Mathf.Abs(moveX));

		//myRB.velocity = new Vector2 (moveX * Kecepatan, myRB.velocity.y);

		//if (Input.GetButtonDown("Jump"))
		//{
		//	Jump();
		//}

		if (moveX > 0 && !facing) {
			flip ();
		} else if (moveX < 0 && facing) {
			flip ();
		}
	}

	void flip()
	{
		facing = !facing;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
