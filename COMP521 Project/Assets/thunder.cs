using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thunder : MonoBehaviour {

	Light Lightning;
	AudioSource Thunder;
	public float timer;
	public float thundertimer;
	public float max;
	public float force;


	// Use this for initialization
	void Start () {
		Lightning = GetComponent<Light> ();
		Thunder = GetComponent<AudioSource> ();
		max = Random.Range (0.5f, 10);
		Lightning.enabled = false;
		Thunder.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > max) 
			Lightning.enabled = true;
		
		if (timer > max + 0.7) 
			Lightning.enabled = false;

			if (timer > max + 1)
				Thunder.enabled = true;

			if (timer > max + 2) {
				Thunder.enabled = false;
				timer = 0;
				max = Random.Range (0.5f, 10);
			}


		
	}
}
