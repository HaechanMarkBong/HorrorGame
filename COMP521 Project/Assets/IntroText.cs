using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {


	Text text;
	float timer;    

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.enabled = true;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 5)
			text.enabled = false;

	}
}