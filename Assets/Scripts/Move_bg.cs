using UnityEngine;
using System.Collections;

public class Move_bg : MonoBehaviour {
	float speed = 1;
	Vector3 pos;
	// Use this for initialization
	void Start () {
	
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		
		pos = transform.position;
		pos += Vector3.down;
		transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * speed);
	}


}
