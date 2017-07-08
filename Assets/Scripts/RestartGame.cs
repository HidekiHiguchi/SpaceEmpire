using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using CnControls;

public class RestartGame : MonoBehaviour {
	
	public Button retry;
	public Button levelSelect;
	public Button upgrades;
	public Button mainMenu;

	void Start () {
		retry.onClick.AddListener (RetryGame);
		levelSelect.onClick.AddListener (SelectLevel);
		upgrades.onClick.AddListener (EnterUpgrades);
		mainMenu.onClick.AddListener (BackToTitle);
	}

	void RetryGame() {
		Application.LoadLevel ("Phase1");
	}

	void SelectLevel() {

	}

	void EnterUpgrades() {

	}

	void BackToTitle() {
		Application.LoadLevel ("MainMenu");
	}



}
