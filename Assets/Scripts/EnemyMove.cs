using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	
	float speed = 5;
	float hSpeed = 10;
	public GameObject explosion;
	Vector3 posOld;
	int count;
	bool isChanging;
	bool change;
	Vector3 pos;
	int hp;
	float timeToChangeWay;
	float timeLeft;
	ScorePoints scoreP;


	// Use this for initialization
	void Start () {
		scoreP = GameObject.FindGameObjectWithTag ("Player").GetComponent (typeof(ScorePoints)) as ScorePoints;
		timeToChangeWay = 2;
		timeLeft = timeToChangeWay;
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

		isChanging = false;
		
		hp = 20;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			other.SendMessage ("applyDamage", 10);
			GameObject explo = (GameObject)Instantiate (explosion);
			explo.transform.position = this.transform.position;
            scoreP.SendMessage("updateScore", 10);
            Destroy(this.gameObject);
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


		timeLeft -= Time.deltaTime;
		if (timeLeft < 0 && isChanging == false) {
			isChanging = true;
			timeLeft = timeToChangeWay;
		}

		if (isChanging) {
			isChanging = false;
			timeLeft = timeToChangeWay;
		}

		if (isChanging) {
			if (!change) {
				pos.x += hSpeed * Time.deltaTime;
				transform.position = pos;
			} else {
				pos.x -= hSpeed * Time.deltaTime;
				transform.position = pos;
			}
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
			scoreP.SendMessage ("updateScore", 10);
			Destroy (this.gameObject);
		}


	}

	void applyDamage(int dmg) {
		hp -= dmg;
	}

	//void Update() {

	//}
}
