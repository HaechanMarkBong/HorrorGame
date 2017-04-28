using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour {

	int timer;
	Light Halo;
	Light Point;

	// Use this for initialization
	void Start () {

		Halo = transform.GetChild(0).GetComponent<Light>();
		Point = transform.GetChild(1).GetComponent<Light>();

	}

	// Update is called once per frame
	void Update () {

		timer = Random.Range(1, 6);

		if(timer%3==0)
		{
			Halo.range = 0;
			Point.range = 0;
		}
		else
		{
			Halo.range = 4;
			Point.range = 1;
		}
	}
}
