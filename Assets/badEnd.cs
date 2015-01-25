using UnityEngine;
using System.Collections;

public class badEnd : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//StartCoroutine("gameOver");
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			StartCoroutine("gameOver");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator gameOver()
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel("mehending");
	}
}
