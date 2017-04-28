using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAppear : MonoBehaviour {

	GameObject girl;
	float timer;
	bool done;
	bool crossed;
	// Use this for initialization
	void Start () {
		girl = GameObject.Find("girl");
		timer = 0;
		done = false;
		crossed = false;
	}

	// Update is called once per frame
	void Update () {
		if(crossed)
			timer += Time.deltaTime;
		if (timer > 1) {
			girl.transform.position = new Vector3 (500, 500, 500);
			crossed = false;
			timer = 0;
		}

	}
	private void OnTriggerEnter(Collider other)
	{
		if (!crossed)
		{
			crossed = true;
			girl.transform.position = new Vector3(304,0,664);
			Quaternion aRotation = new Quaternion ();
			aRotation.eulerAngles = new Vector3 (0, 270, 0);
			girl.transform.rotation = aRotation;
			GetComponent<AudioSource> ().Play ();

		}
	}


}