using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour 
{
	public Rigidbody2D weapon;
	
	public float shootSpeed = 0.0f;

	public float time = 0.0f;

	// Use this fr initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		time += Time.deltaTime;

		if (time >= 3.18f)
		{
			Rigidbody2D bulletInstance = Instantiate (weapon, transform.position, transform.rotation) as Rigidbody2D;
			
			bulletInstance.velocity = transform.right * shootSpeed;
			time = 0f;
			

		}
	
	}
}
