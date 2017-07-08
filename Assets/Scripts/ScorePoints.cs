using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScorePoints : MonoBehaviour {
	public Text score;

	// Use this for initialization
	void Start () {
		score.text = "0";
	}
	
	// Update is called once per frame
	void updateScore(int pnts) {
		score.text = string.Concat(int.Parse (score.text) + pnts);
	}
}
