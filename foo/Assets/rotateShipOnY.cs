﻿using UnityEngine;
using System.Collections;

public class rotateShipOnY : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate( new Vector3(0, 1, 0), Space.Self );
	}
}
