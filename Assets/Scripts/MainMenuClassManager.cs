using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuClassManager : MonoBehaviour {

	// Use this for initialization
	public GameObject glo;
	public GameObject sv;
    private AudioSource[] allAudioSources;

    void Start () {
		GameObject globalV = (GameObject)Instantiate (glo);
		GameObject saveState = (GameObject)Instantiate (sv);

		DontDestroyOnLoad (globalV);
		DontDestroyOnLoad (saveState);

		DontDestroyOnLoad  (this.gameObject);
        StopAllAudio();
        gameObject.GetComponent<AudioSource>().Play();
    }

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }

}
