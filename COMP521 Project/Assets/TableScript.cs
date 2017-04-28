using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour {

	public GameObject fish;
	bool interact;
	float timer;

	// Use this for initialization
	void Start () {
		interact = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (interact)
			timer += Time.deltaTime;
		if (timer > 3) {
			fish.SetActive (false);
			interact = false;
		}
		
	}

	void OnMouseDown(){
		interact = true;
		fish.SetActive (true);
		GetComponent<AudioSource> ().Play ();
	}
}
