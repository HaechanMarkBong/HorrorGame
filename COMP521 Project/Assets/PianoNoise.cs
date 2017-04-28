using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoNoise : MonoBehaviour {

	public GameObject text;
	AudioSource piano;
	bool played;
	float timer;

	// Use this for initialization
	void Start () {
		text.SetActive(false);
		piano = GetComponent<AudioSource>();
		played = false;
		timer = 0;
	}

	// Update is called once per frame
	void Update () {

		if(played)
			timer += Time.deltaTime;

		if(timer>10)
			text.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!played)
		{
			piano.Play();
			text.SetActive(true);
			played = true;
		}
	}


}