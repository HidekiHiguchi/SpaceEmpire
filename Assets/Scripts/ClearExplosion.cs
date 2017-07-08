using UnityEngine;
using System.Collections;

public class ClearExplosion : MonoBehaviour {
	float timeLeft = 0.6f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		timeLeft -= Time.deltaTime;

		if (timeLeft <= 0)
			Destroy (this.gameObject);
	
	}
}
