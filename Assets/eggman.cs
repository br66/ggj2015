using UnityEngine;
using System.Collections;

public class eggman : MonoBehaviour 
{
	public Player player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (player) {
						if (player.speedLimit >= 3) {
								Destroy (gameObject);
						}
				}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Application.LoadLevel("3megaman");
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Application.LoadLevel("3megaman");
		}
	}
}
