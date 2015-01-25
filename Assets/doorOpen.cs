using UnityEngine;
using System.Collections;

public class doorOpen : MonoBehaviour 
{
	public CameraFunc camera;

	// Use this for initializatio
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			camera.xSmooth = 4f;
			camera.ySmooth = 4f;

			camera.minXAndY.x = 11.55f;
			camera.minXAndY.y = -1.15f;
		}
	}
}
