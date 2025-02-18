using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Destroys a gameobject after X time.
public class e_Destroy : MonoBehaviour {

	public float time = 5.0f;

	// Use this for initialization
	void Start () {
		Invoke("Destroy", time);
	}

	void Destroy()
	{
		Destroy(gameObject);
	}

}
