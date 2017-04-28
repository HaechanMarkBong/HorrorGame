using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour {

	GameObject rain;
	GameObject thunder;
	GameObject door;
	public GameObject BillyText;
	bool text;
	float timer;

	// Use this for initialization
	void Start () {
		rain = GameObject.Find ("RainPrefab");
		thunder = GameObject.Find("Thunder");
		door= GameObject.Find("Door");
		text = false;
	}

	private void Update(){
		if (text)
			timer += Time.deltaTime;

		if (timer > 4) {
			text = false;
			BillyText.SetActive (false);
			timer = 0;
		}
	}

	private void OnTriggerEnter(Collider other){
		rain.SetActive (false);
		thunder.SetActive (false);
		door.transform.rotation = Quaternion.Euler (0, 0, 0);
		BillyText.SetActive (true);
		text = true;
	}
}
