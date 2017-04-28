using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	public bool opened;
	public bool moving;
	int amount;
	Transform closepos;
	Transform openpos;
	int angle;

	// Use this for initialization
	void Start () {
		opened = false;
		amount = 0;
		angle = 6;
	}

	// Update is called once per frame
	void Update () {
		if(moving)
		{
			amount += angle;
			if(opened)         
				transform.Rotate(new Vector3(0, -angle, 0));
			else
				transform.Rotate(new Vector3(0, angle, 0));

			if (amount == 90)
			{
				opened = !opened;
				moving = false;
				amount = 0;
			}

		}
	}

	private void OnMouseDown()
	{
		GetComponent<AudioSource> ().Play ();
		moving = true;
	}

}