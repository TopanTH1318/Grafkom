using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour {

	public int PlayerSpeed = 10;
	private bool LiatKanan = false;
	private float MoveX;
	private bool isJumping = false;
	public Vector2 power;

	// Use this for initialization
	void Start () {
		power = new Vector2(0,1800);
	}

	// Update is called once per frame
	void Update () {
		PlayerMove();	
	}

	void PlayerMove()
	{
		//Controls
		MoveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown("Jump"))
		{
			Jump();
		}

		//Animations
		//Player Direction
		if (MoveX < 0.0f && LiatKanan == false)
		{
			FlipPlayer();
		} else if (MoveX > 0.0f && LiatKanan == true)
		{
			FlipPlayer();
		}

		//Phisic
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (MoveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump()
	{
		//Jumping

		if (!isJumping)
		{
			GetComponent<Rigidbody2D>().AddForce(power);
			isJumping = true;
		}
	}

	void FlipPlayer()
	{
		LiatKanan = !LiatKanan;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.transform.tag == "Ground")
			isJumping = false;
	}
}