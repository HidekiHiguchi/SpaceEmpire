using UnityEngine;
using System.Collections;
using CnControls;

public class Laser_shoter : MonoBehaviour {

	public GameObject Laser1;
	//bool shotCooldown = false;
	//float shotCooldownCount = 0.2f;
	//float timeLeft;
	// Use this for initialization
	void Start () {
		//timeLeft = shotCooldownCount;
	}


	public void shotNow() {
		GameObject laser1 = (GameObject)Instantiate (Laser1);
		laser1.transform.position = transform.position;
	}

	// Update is called once per frame
	void Update () {



		/*
		if (shotCooldown == false) {
			if (Input.GetKey (KeyCode.Space) || CnInputManager.GetButton("Jump")) {
				GameObject laser1 = (GameObject)Instantiate (Laser1);
				laser1.transform.position = transform.position;
				shotCooldown = true;
				timeLeft = shotCooldownCount;
			}
		}

		timeLeft -= Time.deltaTime;
			
		if(timeLeft < 0) {
			shotCooldown = false;
		}
		*/
			
	}

}
