using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOnClick : MonoBehaviour {
	
	public Button camp;
	public Button arcade;
	public Button upgrades;
	public Button settings;
	public Button quit;


	// Use this for initialization
	void Start () {
		camp.onClick.AddListener (EnterCampaign);
		arcade.onClick.AddListener (EnterArcade);
		upgrades.onClick.AddListener (EnterUpgrades);
		settings.onClick.AddListener (EnterSettings);
		quit.onClick.AddListener (QuitGame);
	}

	void EnterCampaign() {
        SceneManager.LoadScene("LevelSelection");
        playMenuClick();

    }

    void EnterArcade() {
		Application.OpenURL ("lmgtfy.com/?q=só+queria+dizer+que+esse+botão+vai+demorar+pra+funcionar");
        playMenuClick();
    }

    void EnterUpgrades() {
        playMenuClick();
    }

    void EnterSettings() {
        playMenuClick();
    }



    void QuitGame() {
        playMenuClick();
        Application.Quit();
	}

    void playMenuClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
