using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour {

    private GameObject musicButton;
    private GameObject soundButton;
    private GameObject settingsBackground;

    private bool statusSettings = false;

	// Use this for initialization
	void Start () {
        musicButton = GameObject.Find("MusicOnOffButton");
        soundButton = GameObject.Find("SoundOnOffButton");
        settingsBackground = GameObject.Find("SettingsBackground");

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
}
