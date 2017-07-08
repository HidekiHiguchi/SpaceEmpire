using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionOnClick : MonoBehaviour {

	public Button level1;
	public Button level2;
	public GlobalVariables gv;


	// Use this for initialization
	void Start () {
		gv = GameObject.FindGameObjectWithTag ("GlobalVariables").GetComponent (typeof(GlobalVariables)) as GlobalVariables;
		level1.onClick.AddListener (EnterLevel1);
		level2.onClick.AddListener (EnterLevel2);

	}

	void EnterLevel1() {
		gv.levelToLoad = "Phase1";
		Application.LoadLevel ("LoadingScreen");
	}

	void EnterLevel2() {
		Application.OpenURL ("lmgtfy.com/?q=só+queria+dizer+que+esse+botão+vai+demorar+pra+funcionar");
	}
}
