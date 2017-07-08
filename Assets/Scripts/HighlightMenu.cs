using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightMenu : MonoBehaviour {
	Text op;
	// Use this for initialization
	void Start () {
		op = gameObject.GetComponent(typeof(Text)) as Text;
	}

	void OnMouseEnter() {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
