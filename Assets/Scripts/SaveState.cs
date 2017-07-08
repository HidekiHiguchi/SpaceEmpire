using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour {

	public string arcadeHighestScore;
	public int currentLevel;
	public List<Ship> ships;
	Ship shipTmp;
	public int selectedShip;
	public float arcadeCoins;
	public float campaignCoins;

	//sound settings
	public bool music;
	public bool ambient;
	public bool hardcore;

	// Use this for initialization
	void Awake() {
	}

	void Start () {
		
		if (ships.Count == 0){
			Debug.Log("got in");
			shipTmp = new Ship ();
			shipTmp.baseSpeed = 50;
			shipTmp.upgradeSpeed = 0;
			shipTmp.name = "default";
			shipTmp.hp = 101;
			selectedShip = 0;
			ships.Add (shipTmp);


			music = true;
			ambient = true;
			hardcore = false;

		}
	}


	//public static Ship getSelectedShip() {
		//return ships [0];
	//}

}
