using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour {

	GameObject door;
	EntryDoor script;
	public GameObject Billy;
	float timer;
	bool taken;
	public GameObject grave;
	Grave aGrave;

	// Use this for initialization
	void Start () {
		door = GameObject.Find ("Door");
		script = door.GetComponent<EntryDoor>();
		taken = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (taken)
			timer += Time.deltaTime;
		if (timer > 6) {
			Billy.SetActive (false);
			gameObject.SetActive (false);
		}
	}
		
	void OnMouseDown(){
		Billy.SetActive (true);
		script.locked = false;
		taken = true;
		aGrave = grave.GetComponent<Grave>();
		aGrave.diary = true;
		GetComponent<AudioSource> ().Play ();
	}


}
