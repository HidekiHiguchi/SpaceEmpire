using UnityEngine;
using System.Collections;

public class EnemyMoveSidewaysOnly : MonoBehaviour {

	float speed = 5;
	float hSpeed = 10;
	public GameObject explosion;
	Vector3 posOld;
	int count;
	bool change;
	Vector3 pos;
	int hp;


	// Use this for initialization
	void Start () {
		count = 0;
		if (Random.Range (20, 0) > 10)
			change = false;
		else
			change = true;

		if (Random.Range (20, 0) > 15)
			speed += 5;
		if (Random.Range (20, 0) > 15)
			hSpeed += 10;
		else if (Random.Range (20, 0) > 18) {
			hSpeed = 0;
			speed += 5;
		}

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

		if (Random.Range (200, 0) == 200)
			change = !change;

		pos = Camera.main.WorldToViewportPoint (transform.position); // stay inside of the camera view
		pos.x = Mathf.Clamp(pos.x, 0.04f, 0.96f);
		transform.position = Camera.main.ViewportToWorldPoint(pos);


		pos = transform.position;
		pos.y -= speed * Time.deltaTime;


		if (!change) {
			pos.x += hSpeed * Time.deltaTime;
			transform.position = pos;
		} else {
			pos.x -= hSpeed * Time.deltaTime;
			transform.position = pos;
		}

		if (count == 3) {
			if (posOld.x == pos.x) {
				change = !change;
			}
			posOld = pos;
			count = 0;
		}

		//Random.Range (9000f, 1f);Random
		transform.position = pos;

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
