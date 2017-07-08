using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuClassManager : MonoBehaviour {

	// Use this for initialization
	public GameObject glo;
	public GameObject sv;

	void Start () {
		GameObject globalV = (GameObject)Instantiate (glo);
		GameObject saveState = (GameObject)Instantiate (sv);

		DontDestroyOnLoad (globalV);
		DontDestroyOnLoad (saveState);

		DontDestroyOnLoad  (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
