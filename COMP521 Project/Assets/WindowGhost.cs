using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowGhost : MonoBehaviour {


	GameObject girl;
	public double aTime;
	bool hit;

	// Use this for initialization
	void Start () {
		girl = GameObject.Find ("girl");
		hit = false;
		aTime = 0;
	}
	void Update() {
		
			if(hit)
				aTime += Time.deltaTime;
		//girl.transform.position = new Vector3 (500, 500, 500);

		if (aTime > 1.5) {
			girl.transform.position = new Vector3 (500, 500, 500);
			aTime = 0;
			hit = false;
		}

	}

	void OnTriggerEnter(Collider other){
		if (!hit) {
			hit = true;
				girl.transform.position = new Vector3 (transform.position.x + 5, transform.position.y - 4, transform.position.z);
				Quaternion aRotation = new Quaternion ();
				aRotation.eulerAngles = new Vector3 (0, -90, 0);
				girl.transform.rotation = aRotation;
				GetComponent<AudioSource> ().Play ();

		}
	}
}
