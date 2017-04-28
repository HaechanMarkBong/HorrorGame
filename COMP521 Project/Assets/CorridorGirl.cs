using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorGirl : MonoBehaviour {

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
		if(timer>4 && timer < 4.5)
		{
			girl.transform.position = new Vector3(260, 0.2f, 700);
			GetComponent<AudioSource> ().Play ();
		}
		if (timer > 4.5 && !done)
		{
			done = true;
			girl.transform.position = new Vector3(500, 500, 500);
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (!crossed)
		{
			crossed = true;
			girl.transform.position = new Vector3(235,0.2f,700);
			Quaternion aRotation = new Quaternion ();
			aRotation.eulerAngles = new Vector3 (0, 90, 0);
			girl.transform.rotation = aRotation;
		}
	}


}