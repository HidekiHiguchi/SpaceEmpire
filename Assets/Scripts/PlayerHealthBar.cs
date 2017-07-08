using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

	public Slider hp;

	void Start() {

		hp.maxValue = 100;
		hp.minValue = 0;

		hp.value = hp.maxValue;
	}
		

	void healthBarUpdate(int playerHP) {
		hp.value = playerHP;
	}
		
}
