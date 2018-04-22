using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using CnControls;
using UnityEngine.SceneManagement;

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
        playMenuClick();

        SceneManager.LoadScene("Phase1");
	}

	void SelectLevel() {
        playMenuClick();

    }

	void EnterUpgrades() {
        playMenuClick();

    }

	void BackToTitle() {
        playMenuClick();
        SceneManager.LoadScene("Intro");
	}
    void playMenuClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }


}
