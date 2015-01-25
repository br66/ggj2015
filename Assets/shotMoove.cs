using UnityEngine;
using System.Collections;

public class shotMoove : MonoBehaviour 
{
	public float existenceTime = 0.0f;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, existenceTime);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
