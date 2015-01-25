using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float speed = 1.0f;
	public float speedLimit = 0f;

	public float jumpLimit = 0f;

	public string left = "Horizontal";
	private string jump = "Fire1";

	public float jumpPower = 1200.0f;

	private GameObject deadEnemy;

	//public Animator anim

	public Transform groundCheck;
	public bool grounded = false;

	public GameObject win;

	// Use this for initializati
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

		if (Input.GetAxis (left) < 0)
		{
			Vector3 newScale = transform.localScale;
			newScale.x = -1.0f;
			transform.localScale = newScale;
		}
		else if (Input.GetAxis (left) > 0)
		{
			Vector3 newScale = transform.localScale;
			newScale.x = 1.0f;
			transform.localScale = newScale;
		}
	
		//transform.position += transform.right * Input.GetAxis(left) * speed * Time.deltaTime;
		rigidbody2D.AddForce (transform.right*Input.GetAxis(left) * speed);

		if (Application.loadedLevelName != "2sonic") 
		{
			if (Mathf.Abs (rigidbody2D.velocity.x) > speedLimit) 
			{
				if (rigidbody2D.velocity.x < -1) 
				{
					//Debug.Log("negative restiction");
					rigidbody2D.velocity = new Vector2 (-speedLimit, rigidbody2D.velocity.y);
				}
			
				if (rigidbody2D.velocity.x > 1) 
				{
					//Debug.Log("positive restiction");
					rigidbody2D.velocity = new Vector2 (speedLimit, rigidbody2D.velocity.y);
				}
			}
		}
	}

	void Update ()
	{
		if (Input.GetButtonDown (jump) && grounded) 
		{
			rigidbody2D.AddForce(transform.up * jumpPower);
		}
		
		if (Mathf.Abs (rigidbody2D.velocity.y) > jumpLimit)
		{
			if (rigidbody2D.velocity.y < -1)
			{
				//Debug.Log("negative restiction");
				rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, -jumpLimit);
			}
			
			if (rigidbody2D.velocity.y > 1)
			{
				//Debug.Log("positive restiction");
				rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, jumpLimit);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.collider.gameObject.tag == "KillEnemy")
		{
			deadEnemy = collision.gameObject;
			Destroy(deadEnemy);
		}else
			if (collision.collider.gameObject.tag == "DontKillEnemy")
		{
			Application.LoadLevel("1platform");
		}

		if (collision.gameObject.tag == "Box")
		{
			this.speedLimit = 3f;
			this.speed *= 35f;
			Destroy (collision.gameObject);
			if (win)
			{
				Destroy (win);
			}
		}
		if (collision.gameObject.tag == "Side Bumper")
		{
			rigidbody2D.AddForce(transform.right * jumpPower * 34f);
			//rigidbody2D.velocity += new Vector2 (10f, rigidbody2D.velocity.y)
			//rigidbody2D.AddTorque (50f)
		}
		if (collision.gameObject.tag == "Bumper")
		{
			rigidbody2D.AddForce(transform.up *jumpPower * 66f);
		}

		if (collision.gameObject.tag == "Dead2ndLevel")
		{
			Application.LoadLevel("2sonic");
		}
	}
}