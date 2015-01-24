using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float speed = 1.0f;
	public float speedLimit = 0f;

	private string left = "Horizontal";
	private string jump = "Fire1";

	public float jumpPower = 1200.0f;

	//public Animator anim;



	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{
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


		if (Input.GetButtonDown (jump)) 
		{
			rigidbody2D.AddForce(transform.up * jumpPower);
		}

		if (Mathf.Abs (rigidbody2D.velocity.x) > speedLimit)
		{
			Debug.Log ("reached limit");
			if (rigidbody2D.velocity.x < -1)
			{
				Debug.Log("negative restiction");
				rigidbody2D.velocity = new Vector2 (-speedLimit, rigidbody2D.velocity.y);
			}
			
			if (rigidbody2D.velocity.x > 1)
			{
				Debug.Log("positive restiction");
				rigidbody2D.velocity = new Vector2 (speedLimit, rigidbody2D.velocity.y);
			}
		}

	}

}
