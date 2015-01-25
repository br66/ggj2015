using UnityEngine;
using System.Collections;

public class goomba : MonoBehaviour 
{
	public int health = 1;			//Maximum health, but I may not use it. It's actually not in use as of now
	public float moveSpeed = 0f;	//Initial speed of the enemy. May be changed.
	public Transform head;			//Used to determine if something is obstructing the front of enemy.
	private bool isZero; 			//Used for fixing the "Not Moving" bug/glitch. More info below.
	public Player player;

	public bool timer = true;

	public float time = 0.0f;

	// Use this for initializatio
	void Start () 
	{
		//StartCoroutine("howYouWin");

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		time += Time.deltaTime;
		rigidbody2D.velocity = new Vector2 (transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);

		//Debug.Log (time);

		if (Input.GetAxis(player.left) != 0)
		{
			time = 0f;
			Debug.Log ("no co");
		}

		if (time >= 10.0f)
		{
			Application.LoadLevel("2sonic");
		}
		//if (timer == true)
		//{
		//	StartCoroutine("howYouWin");
		//	Debug.Log ("co");
		//}

	}

	//void OnTriggerEnter2D (Collider2D col)
	//{
	//	if (col.gameObject.tag == "Respawn")
	//	{
	//		Destroy (gameObject);
	//	}
	//}
	
}
