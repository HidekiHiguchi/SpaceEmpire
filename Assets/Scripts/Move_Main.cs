using UnityEngine;
using System.Collections;
using CnControls;
using System.Collections.Generic;

public class Move_Main : MonoBehaviour {
	public GameObject explosion;
	float speed = 80.0f;
	Vector3 pos;
	Vector3 analog;
	int hp;
	PlayerHealthBar hpBar;
	CooldownBar cdBar;
	Component[] lasers;
	bool shotCooldown = false;
	float shotCooldownCount = 0.2f;
	float timeLeft;
	CooldownBar barCooldownRef;
	bool cooldownBar = false;
	SaveState saveState;
	Ship shi;

	// Use this for initialization
	void Start () {
		//saveState = GameObject.FindGameObjectWithTag ("SaveState").GetComponent (typeof(SaveState)) as SaveState;

		//hp = saveState.getSelectedShip ().hp;
		hp = 30;

		hpBar = gameObject.GetComponent (typeof(PlayerHealthBar)) as PlayerHealthBar;
		cdBar = gameObject.GetComponent (typeof(CooldownBar)) as CooldownBar;
		lasers = GetComponentsInChildren( typeof(Laser_shoter) );
		barCooldownRef = GetComponentInChildren( typeof(CooldownBar) ) as CooldownBar;
		timeLeft = shotCooldownCount;
	}

	// Update is called once per frame
	void Update () {
		

		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position); // stay inside of the camera view
		pos.x = Mathf.Clamp(pos.x, 0.04f, 0.96f);
		pos.y = Mathf.Clamp(pos.y, 0.07f, 0.95f);
		transform.position = Camera.main.ViewportToWorldPoint(pos);
		
		analog	= new Vector3(CnInputManager.GetAxis ("Horizontal"), CnInputManager.GetAxis ("Vertical"), 0f);


		if (Input.GetKey (KeyCode.D) || analog.x > 0.3 ) {
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * speed);
			}
		if (Input.GetKey (KeyCode.A) || analog.x < -0.3) {
				//pos += Vector2.left;
				GetComponent<Rigidbody2D> ().AddForce (Vector2.left * speed);

			}
		if (Input.GetKey (KeyCode.S) || analog.y < -0.3) {
				//pos += Vector2.down;
				GetComponent<Rigidbody2D> ().AddForce (Vector2.down * speed);
			}
		if (Input.GetKey (KeyCode.W) || analog.y > 0.3) {
				//pos += Vector2.up;
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * speed);
			}

		analog = Vector3.zero;

		//GetComponent<Rigidbody2D> ().AddForce (Vector2.right * speed);
		//transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * speed);



		//shot logic

		if (shotCooldown == false && cooldownBar == false) {
			if (Input.GetKey (KeyCode.Space) || CnInputManager.GetButton("Jump")) {
				foreach(Laser_shoter laser in lasers) {
					laser.SendMessage ("shotNow");
					barCooldownRef.SendMessage ("countdownCDB");
				}
				shotCooldown = true;
				timeLeft = shotCooldownCount;
			}
		}



		timeLeft -= Time.deltaTime;

		if(timeLeft < 0) {
			shotCooldown = false;
		}




		if (hp < 1) {
			GameObject explo = (GameObject)Instantiate (explosion);
			explo.transform.position = this.transform.position;
			Application.LoadLevel ("DeadScreen");
			Destroy (this.gameObject);
		}
	}


	public void setCooldownBarTrue() {
		cooldownBar = true;
	}

	public void setCooldownBarFalse() {
		cooldownBar = false;

	}


	void applyDamage(int dmg) {
		hp -= dmg;
		hpBar.SendMessage ("healthBarUpdate", hp);
	}
}