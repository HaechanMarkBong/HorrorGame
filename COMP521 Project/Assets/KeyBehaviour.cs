using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour {

	public GameObject locket;
	Box aBox;
	public GameObject billytext;
	float timer;
	bool haskey;

	// Use this for initialization
	void Start () {
		aBox = locket.GetComponent<Box> ();
		timer = 0;
		haskey = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (haskey)
			timer += Time.deltaTime;

		if (timer > 3) {
			billytext.SetActive (false);
			gameObject.SetActive (false);
			haskey = false;
			timer = 0;
		}
	}

	void OnMouseDown(){
		aBox.locked = false;
		billytext.SetActive(true);
		haskey = true;
		GetComponent<AudioSource> ().Play ();
	}

}
