using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Slider currentVolume;
    public Toggle muteToggle;

    void Start()
    {
        GetValues();
    }

    void Update()
    {
       if (Input.GetKeyDown("escape")) Application.Quit(); 
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Music");
    }

    public void GetValues()
    {
        currentVolume.value = PlayerPrefs.GetFloat("currentVolume");
        muteToggle.isOn = MuteStatus();
    }

    bool MuteStatus()
    {
        return PlayerPrefs.GetInt("muteToggle") == 1 ? true : false;
    }

    public void SetVolume()
    {
        PlayerPrefs.SetFloat("currentVolume", currentVolume.value);
        if(!muteToggle.isOn) PlayerPrefs.SetFloat("volume", currentVolume.value);
        SliderMuteCheck();
    }

    public void SetMute()
    {
        PlayerPrefs.SetInt("muteToggle", (muteToggle.isOn ? 1 : 0));
        SliderMuteCheck();
        currentVolume.value = (muteToggle.isOn ? 0f : PlayerPrefs.GetFloat("volume"));
    }

    void SliderMuteCheck()
    {
        currentVolume.value = (muteToggle.isOn ? 0f : PlayerPrefs.GetFloat("currentVolume"));
    }

}
