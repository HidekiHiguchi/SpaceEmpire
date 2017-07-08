using UnityEngine;
using System.Collections;

public class ResetBG : MonoBehaviour {
	Vector3 pos;
	public GameObject Bg1;
	// Use this for initialization
	void Start () {
		pos.x = 1182f;
		pos.y = 685f;
		GameObject bg1 = (GameObject)Instantiate (Bg1);
		bg1.transform.position = pos;
		pos = transform.position;

	}

	void OnTriggerExit2D(Collider2D other) {
		GameObject bg1 = (GameObject)Instantiate (Bg1);
		bg1.transform.position = pos;
	}


	// Update is called once per frame
	void Update () {
	}
}
