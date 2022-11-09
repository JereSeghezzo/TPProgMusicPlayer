using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayerController : MonoBehaviour
{
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("currentVolume");
        audioSource.time = PlayerPrefs.GetInt("timeCounter");
        audioSource.Play();
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
        PlayerPrefs.SetInt("timeCounter", Mathf.RoundToInt(audioSource.time));
    }

    void RestartSong()
    {
        if (Input.GetKeyDown("space")) audioSource.time = 0f;
    }
}
