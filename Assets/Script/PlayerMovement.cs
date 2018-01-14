using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//movemenr variables
	public float Kecepatan = 10;

	//jumping variables
	bool grounded = false;
	float groundCheckRadius = 0.2f;
	public LayerMask groundLayer;
	public Transform groundCheck;
	public float jumpHeight; 

	private Rigidbody2D myRB;
	private Animator myAnim;
	private float moveX;
	public bool facing;
	//public Vector2 power = new Vector2(0,1800);
	//private bool isJumping = false;

	//rocket
	public Transform gun;
	public GameObject bullet;
	public float firerate = 1f;
	public float nextfire = 0f;

	//bola
	public GameObject Batu;

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

	void fireRocket()
	{
		if (Time.time > nextfire) 
		{
			nextfire = Time.time + firerate;
			if (facing) 
			{
				Instantiate (bullet, gun.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
			} 
			else if (!facing) 
			{
				Instantiate (bullet, gun.position, Quaternion.Euler (new Vector3 (0, 0, 180f)));
			}
		}
	}

	//private void OnCollisionStay2D(Collision2D collision)
	//{
	//	if (collision.transform.tag == "Ground")
	//		isJumping = false;
	//}

	void Update()
	{
		if(grounded && Input.GetAxis("Jump")>0){
			grounded = false;
			//myAnim.SetBool ("isGrounded", grounded);
			myRB.AddForce(new Vector2(0,jumpHeight));
		}
		//player shooting
		if(Input.GetAxisRaw("Fire1")>0) fireRocket();
	}

	// Update is called once per frame
	void FixedUpdate () {

		//check if we are grounded - if no we are falling
		grounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,groundLayer);
		//myAnim.SetBool ("isGrounded", grounded);

		//myAnim.SetFloat("verticalSpeed",myRB.velocity.y);

		moveX = Input.GetAxis ("Horizontal");
		myAnim.SetFloat("Speed",Mathf.Abs(moveX));

		myRB.velocity = new Vector2 (moveX * Kecepatan, myRB.velocity.y);

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

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.tag == "Batu") {
			Batu.SetActive (true);
		}
	}		
}
