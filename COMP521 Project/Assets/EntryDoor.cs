using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryDoor : MonoBehaviour
{

	public bool opened;
	public bool moving;
	int amount;
	Transform closepos;
	Transform openpos;
	int angle;
	GameObject player;
	public bool locked;
	public bool start;
	public GameObject billyLock;
	float timer;
	bool billy;
	public GameObject billyOut;


	// Use this for initialization
	// Use this for initialization
	void Start()
	{
		start = true;
		locked = false;
		player = GameObject.Find("FPSController");
		opened = false;
		amount = 0;
		angle = 1;
		timer = 0;
		billy = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (billy)
			timer += Time.deltaTime;
		if (timer > 3) {
			billy = false;
			billyLock.SetActive (false);
			billyOut.SetActive (false);
			timer = 0;
		}

		if (moving)
		{
			amount += angle;
			if (opened)
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

		if(start && opened)
		{
			opened = false;
			locked = true;
			start = false;
		}
	}

	private void OnMouseDown()
	{
		if (!locked) {
			GetComponent<AudioSource> ().Play ();
				transform.Rotate(new Vector3(0, -angle, 0));
				moving = true;
			if (!start) {
				billyOut.SetActive (true);
				billy = true;
			}
		} else {
			billy = true;
			billyLock.SetActive (true);
		}
	}

	private double distance()
	{
		float X = transform.position.x - player.transform.position.x;
		float Y = transform.position.y - player.transform.position.y;

		return Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));
	}

}