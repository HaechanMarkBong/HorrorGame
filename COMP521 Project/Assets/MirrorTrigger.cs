using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTrigger : MonoBehaviour {

	GameObject mirror;
	public float timer;
	public bool scary;

	// Use this for initialization
	void Start () {
		mirror = GameObject.Find("mirrorscary");
		mirror.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

		if(scary)
			timer += Time.deltaTime;
		if(timer>2)
		{
			scary = false;
			mirror.SetActive(false);
			timer = 0;
		}



	}

	private void OnTriggerEnter(Collider other)
	{
		scary = true;
		GetComponent<AudioSource> ().Play ();
		mirror.SetActive(true);
	}
}