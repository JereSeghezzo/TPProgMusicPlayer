using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
   public Slider volumeSlider;
   public Toggle muteToggle;

    void Start()
    {
        GetValues();    
    }
 public void PlayButton()
    {
      SceneManager.LoadScene("Music");
    }

 public void GetValues()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumeSlider");
        muteToggle.isOn = MuteStatus();
    }

 bool MuteStatus()
    {
       return PlayerPrefs.GetInt("muteToggle") == 1 ? true : false;  
    }

    public void SetVolume()
    {
        PlayerPrefs.SetFloat("volumeSlider", volumeSlider.value);
    }

    public void SetMute()
    {
        PlayerPrefs.SetInt("muteToggle", (muteToggle.isOn ? 1 : 0));
    }
}
