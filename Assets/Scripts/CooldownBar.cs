using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CooldownBar : MonoBehaviour {

	Move_Main mm;
	public Slider cooldown;
	float timeLeft;
	float timeToRegen;
	float regen;
	void Start() {

		mm = GetComponent (typeof(Move_Main)) as Move_Main;
		cooldown.maxValue = 30;
		cooldown.minValue = 0;
		timeToRegen = 1.5f;
		timeLeft = timeToRegen;
		cooldown.value = cooldown.maxValue;
		regen = 4;

	}

	void countdownCDB() {
		cooldown.value -= 1;
	}


	void CooldownBarUpdate(int playerCD) {
		cooldown.value = playerCD;
	}

	void Update() {
		if (cooldown.value <= cooldown.minValue) {

			mm.SendMessage ("setCooldownBarTrue");

		}

		timeLeft -= Time.deltaTime;

		if(timeLeft < 0) {
			cooldown.value += regen;
			timeLeft = timeToRegen;
		}

		if (cooldown.value > 0) {
			mm.SendMessage ("setCooldownBarFalse");
		}


	}

}
