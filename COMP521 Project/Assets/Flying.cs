using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObjs : MonoBehaviour {

	float time;
	Rigidbody rigid;

	void Start() {
		time = 0;
		rigid = GetComponent<Rigidbody>();
		rigid.useGravity = true;
		rigid.isKinematic = true;
	}

	void Update(){
		time += Time.deltaTime;
		if(time>0){
			float x = Random.Range (-10, 10);
			float y = Random.Range (-10, 10);
			float z = Random.Range (-10, 10);
			rigid.useGravity = false;
			rigid.isKinematic = false;
			rigid.velocity = new Vector3 (x, y, z);
			time = -5;
		}		
	}

}