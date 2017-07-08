using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {
	public GlobalVariables gv;
	float timeLeft;
	// Use this for initialization
	void Start () {
		timeLeft = 2;
		gv = GameObject.FindGameObjectWithTag ("GlobalVariables").GetComponent (typeof(GlobalVariables)) as GlobalVariables;

	}

	void Update() {
		timeLeft -= Time.deltaTime;

		if(timeLeft < 0) {
			Application.LoadLevel (gv.levelToLoad);
		}
	}

}
