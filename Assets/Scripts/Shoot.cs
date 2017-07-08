using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	float speed = 50;
	Vector3 force = Vector3.zero;
	int dmg;

	// Use this for initialization
	void Start () {
		dmg = 10;
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag != "Cleaner")
			other.SendMessage ("applyDamage", 10);
		Destroy (this.gameObject);

	}



	void FixedUpdate () {
		force = transform.position;
		force.y += speed * Time.deltaTime;
		transform.position = force;

		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

		if(transform.position.y > max.y){
			Destroy (gameObject);
		}
	}
}
