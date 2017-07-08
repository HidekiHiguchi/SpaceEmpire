using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour {

	public string levelToLoad;
	public int singleton;

	void Awake() {
		
	}

	// Use this for initialization
	void Start () {
		singleton = 1;
	}
	
	// Update is called once per frame
	string getLevelToLoad() {
		return levelToLoad;
	}
}
