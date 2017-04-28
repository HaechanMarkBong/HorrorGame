using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour {
	public bool diary;
	public GameObject billyGrave;
	public GameObject billyWin;
	public GameObject player;
	bool billy;
	float timer;

	// Use this for initialization
	void Start () {
		diary = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (billy)
			timer += Time.deltaTime;
		if(timer>3)
		{
			billyGrave.SetActive (false);
			billy = false;
		}
	}

	void OnMouseDown(){
		if (!diary) {
			billyGrave.SetActive (true);
			billy = true;
		} else {
			player.transform.position = new Vector3 (250, -100, 500);
			billyWin.SetActive (true);
		}

	}
}
