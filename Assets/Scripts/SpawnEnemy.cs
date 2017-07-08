using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject s1;
	public GameObject s2;
	public GameObject s3;
	public GameObject ship;
	float t_leftCons = 2;
	float timeLeft;
	// Use this for initialization
	void Start () {
		timeLeft = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			GameObject enemy1 = (GameObject)Instantiate (ship);
			enemy1.transform.position = s1.gameObject.transform.position;


			GameObject enemy2 = (GameObject)Instantiate (ship);
			enemy2.transform.position = s2.gameObject.transform.position;

			GameObject enemy3 = (GameObject)Instantiate (ship);
			enemy3.transform.position = s3.gameObject.transform.position;

			timeLeft = t_leftCons;

		}

	}
}
