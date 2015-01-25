using UnityEngine;
using System.Collections;

public class protoScript : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if anim.animation == 
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Application.LoadLevel ("3megaman");
		}
	}
}
