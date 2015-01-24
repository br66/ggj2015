using UnityEngine;
using System.Collections;

public class goomba : MonoBehaviour 
{
	public int health = 1;			//Maximum health, but I may not use it. It's actually not in use as of now.
	public float moveSpeed = 0f;	//Initial speed of the enemy. May be changed.
	public Transform head;			//Used to determine if something is obstructing the front of enemy.
	private bool isZero; 			//Used for fixing the "Not Moving" bug/glitch. More info below.	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rigidbody2D.velocity = new Vector2 (transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);
	
	}
}
