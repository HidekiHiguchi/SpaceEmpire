using UnityEngine;
using System.Collections;

public class FitScreen : MonoBehaviour {
	Vector3 screen;
	Vector3 cam;
	public GameObject Wleft;
	public GameObject Wright;
	Vector3 nPosL;
	Vector3 nPosR;
	void Start () {

	

		/*
		cam = Camera.main.gameObject.transform.position;



		float screenWidth = Screen.width / Screen.dpi;
		float screenHeight = Screen.height / Screen.dpi;
		float diagonalInches = Mathf.Sqrt (Mathf.Pow (screenWidth, 2) + Mathf.Pow (screenHeight, 2));

		float widthpx = screenWidth * 96;

		float heightpx = screenHeight * 96;

		Debug.Log (widthpx + "\n" + heightpx);





		if (widthpx == 480) {

			nPosL.x = 49;
			nPosL.y = -13;

			nPosR.x = 581.9f;
			nPosR.y = -5f;

			Wleft.transform.position = nPosL;
			Wright.transform.position = nPosR;

		} else if (widthpx == 800) {
			
			nPosL.x = 20.2f;
			nPosL.y = -13f;

			nPosR.x = 611.6f;
			nPosR.y = -5f;

			Wleft.transform.position = nPosL;
			Wright.transform.position = nPosR;
		} else if (widthpx == 1024) {

			nPosL.x = 13f;
			nPosL.y = -18.67581f;

			nPosR.x = 618.5f;
			nPosR.y = -5f;

			Wleft.transform.position = nPosL;
			Wright.transform.position = nPosR;

		} else if (widthpx == 1280) {

			nPosL.x = 32.1f;
			nPosL.y = -18.67581f;

			nPosR.x = 599.6f;
			nPosR.y = -5f;

			Wleft.transform.position = nPosL;
			Wright.transform.position = nPosR;
		} else if (widthpx == 320) {

			nPosL.x = 79f;
			nPosL.y = -18.67581f;

			nPosR.x = 552.5f;
			nPosR.y = -5f;

			Wleft.transform.position = nPosL;
			Wright.transform.position = nPosR;
		}
		*/



	}
	
	// Update is called once per frame
	void Update () {

	}
}
