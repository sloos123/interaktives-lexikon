using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour {

    public GameObject musicButton;
    public GameObject soundButton;
    public GameObject settingsBackground;

    public bool statusSettings = false;

	// Use this for initialization
	void Start () {
        musicButton = GameObject.Find("Music button");
        soundButton = GameObject.Find("Sound button");
        settingsBackground = GameObject.Find("Settings background");

        musicButton.SetActive(false);
        soundButton.SetActive(false);
        settingsBackground.SetActive(false);
	}

    public void StartGame () {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    public void Settings () {
        if (statusSettings == false){
            musicButton.SetActive(true);
            soundButton.SetActive(true);
            settingsBackground.SetActive(true);

            statusSettings = true;
        } else {
            musicButton.SetActive(false);
            soundButton.SetActive(false);
            settingsBackground.SetActive(false);

            statusSettings = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
