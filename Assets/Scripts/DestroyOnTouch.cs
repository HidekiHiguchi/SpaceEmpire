﻿using UnityEngine;
using System.Collections;

public class DestroyOnTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
