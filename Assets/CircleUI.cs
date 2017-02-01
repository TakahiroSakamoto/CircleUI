using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleUI : MonoBehaviour {
	[SerializeField]
	GameObject MenuPivot;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int)trackedObject.index);
		Vector2 position = device.GetAxis();

		MenuPivot.transform.RotateAround(transform.position, transform.forward, position.x*2);

	}
}
