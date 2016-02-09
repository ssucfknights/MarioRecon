using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour {


	public float maxSpeed = 10f;
	bool facingRight = true;

	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	bool doubleJump = true;

	public Text scoreText;
	public int score;
	private string holder;









	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}


	void Update ()
	{


		UpdateScore ();


		if ((grounded || !doubleJump) && Input.GetKeyDown (KeyCode.Space)) {

			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

			if (!doubleJump && !grounded)
				doubleJump = true;

		
		}



	 

	}



	
	// Update is called once per frame
	void FixedUpdate () {


		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		if (grounded)
			doubleJump = true;

		if (!grounded)
			return;

		float move = Input.GetAxis ("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	
	}



	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}




	void UpdateScore(){



		holder = score.ToString ("D6");
		scoreText.text = holder;

	}

}
