using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayerController : MonoBehaviour
{
    AudioSource song;

    void Awake()
    {
        song = GetComponent<AudioSource>();
        song.volume = PlayerPrefs.GetFloat("currentVolume");
        song.time = PlayerPrefs.GetInt("timeCounter");
        song.Play();
    }


    void Update()
    {
        SetTimeCounter();
        RestartSong();
        if (Input.GetKeyDown("escape")) Application.Quit();
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    void SetTimeCounter()
    {
        PlayerPrefs.SetInt("timeCounter", Mathf.RoundToInt(song.time));
    }

    void RestartSong()
    {
        if (Input.GetKeyDown("space")) song.time = 0f;
    }
}
