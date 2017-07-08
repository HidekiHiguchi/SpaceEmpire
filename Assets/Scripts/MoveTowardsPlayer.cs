using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour {

	float speed = 10;
	float hSpeed = 1;
	float rotSpeed = 10;
	public GameObject player1;
	public GameObject explosion;
	Quaternion rot;
	Vector3 posOld;
	int count;
	bool change;
	Vector3 pos;
	int hp;


	// Use this for initialization
	void Start () {
		count = 0;
		change = false;
		hp = 20;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			other.SendMessage ("applyDamage", 10);
			GameObject explo = (GameObject)Instantiate (explosion);
			explo.transform.position = this.transform.position;
			Destroy (this.gameObject);

		}

	}


	// Update is called once per frame
	void FixedUpdate () {
		count++;

		pos = Camera.main.WorldToViewportPoint (transform.position); // stay inside of the camera view
		pos.x = Mathf.Clamp(pos.x, 0.04f, 0.96f);
		transform.position = Camera.main.ViewportToWorldPoint(pos);

		/*
		//follows the player
		transform.position = Vector3.MoveTowards (transform.position, player1.transform.position, Time.deltaTime * speed); // move towards player
		Vector3 vectorToTarget = player1.transform.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - 90;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotSpeed);
				
		*/

		Vector3 vectorToTarget = player1.transform.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg + 90;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotSpeed);
		transform.position = Vector3.MoveTowards (transform.position, player1.transform.position, Time.deltaTime * speed);

		//pos.z = -3f;
		//pos = transform.position;
		//pos.y -= speed * Time.deltaTime;


		//transform.position = pos;


		if (hp < 1) {

			GameObject explo = (GameObject)Instantiate (explosion);
			explo.transform.position = this.transform.position;

			Destroy (this.gameObject);
		}


	}

	void applyDamage(int dmg) {
		hp -= dmg;
	}

	//void Update() {

	//}
}
