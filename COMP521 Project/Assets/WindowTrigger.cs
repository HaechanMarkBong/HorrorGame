using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigger : MonoBehaviour {

	GameObject girl;
	public float timer;
	public bool hit;

	// Use this for initialization
	void Start () {
		girl= GameObject.Find("girl");
		hit = false;
		timer = 0;

	}

	void Update (){
		timer += Time.deltaTime;
		
		if(timer > 1)
			girl.transform.position = new Vector3 (500, 500, 500);
		timer = 0;
		
	}

	void OnTriggerEnter(Collider other){
		if (!hit) {
			hit = true;
			girl.transform.position = new Vector3 (transform.position.x + 5, transform.position.y - 4, transform.position.z);
			Quaternion aRotation = new Quaternion ();
			aRotation.eulerAngles = new Vector3 (0, -90, 0);
			girl.transform.rotation = aRotation;
		}
	}
}
