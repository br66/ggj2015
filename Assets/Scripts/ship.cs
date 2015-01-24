using UnityEngine;
using System.Collections;

public class ship : MonoBehaviour 
{
	public float speed = 1.0f;
	private string left = "Horizontal";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetAxis (left) < 0)
		{
			Vector3 newScale = transform.localScale;
			//newScale.x = -1.0f;
			transform.localScale = newScale;
		}
		else if (Input.GetAxis (left) > 0)
		{
			Vector3 newScale = transform.localScale;
			//newScale.x = 1.0f;
			transform.localScale = newScale;
		}
		
		transform.position += transform.right * Input.GetAxis(left) * speed * Time.deltaTime;
	
	}
}
