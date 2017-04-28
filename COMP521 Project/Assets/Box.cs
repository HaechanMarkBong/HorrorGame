using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

	public GameObject BillyLocked;
	GameObject Diary;
	GameObject Top;
	public bool locked;
	public float timer;
	public bool billy;

	// Use this for initialization
	void Start () {
		//BillyLocked = GameObject.Find ("BillyBoxLocked");
		Diary = GameObject.Find ("Diary");
		Top = GameObject.Find ("BoxTop");
		locked = true;
		billy = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (billy)
			timer += Time.deltaTime;
		if (timer > 3) {
			BillyLocked.SetActive (false);
			billy = false;
			timer = 0;
		}


	}

	void OnMouseDown(){
		if (locked) {
			BillyLocked.SetActive (true);


		} else {
		
			Top.SetActive (false);
			float y = Diary.transform.position.y + 1;
			float x = Diary.transform.position.x;
			float z = Diary.transform.position.z;

			Diary.transform.position = new Vector3 (x, y, z);
		}
	}
}
