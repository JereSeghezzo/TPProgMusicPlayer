using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LyricsController : MonoBehaviour
{
    public Text lyricsBox;
    public int Time;
    string currentLyric;

    void Awake()
    {
        lyricsBox.text = PlayerPrefs.GetString("currentLyric");
    }

    void Update()
    {
        Time = Mathf.RoundToInt(PlayerPrefs.GetFloat("timeCounter"));
        if (Time == 0) lyricsBox.text = "";
        if (Time == 19) lyricsBox.text = "we're no strangers to love";
        if (Time == 23) lyricsBox.text = "you know the rules and so do i";
        if (Time == 27) lyricsBox.text = "a full commitment's what i'm thinking of";
        if (Time == 32) lyricsBox.text = "you wouldn't get this from any other guy";
        if (Time == 36) lyricsBox.text = "i just wanna tell you how i'm feeling";
        if (Time == 41) lyricsBox.text = "gotta make you understand";
        if (Time == 44) lyricsBox.text = "never gonna give you up";
        if (Time == 46) lyricsBox.text = "never gonna let you down";
        if (Time == 48) lyricsBox.text = "never gonna run around and desert you";
        if (Time == 52) lyricsBox.text = "never gonna make you cry";
        if (Time == 54) lyricsBox.text = "never gonna say goodbye";
        if (Time == 56) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (Time == 60) lyricsBox.text = "";
        if (Time == 61) lyricsBox.text = "we've known each other for so long";
        if (Time == 65) lyricsBox.text = "your heart's been aching, but";
        if (Time == 68) lyricsBox.text = "you're too shy to say it";
        if (Time == 70) lyricsBox.text = "inside, we both know what's been going on";
        if (Time == 74) lyricsBox.text = "we know the game and we're gonna play it";
        if (Time == 78) lyricsBox.text = "and if you ask me how i'm feeling";
        if (Time == 83) lyricsBox.text = "don't tell me you're too blind to see";
        if (Time == 86) lyricsBox.text = "never gonna give you up";
        if (Time == 88) lyricsBox.text = "never gonna let you down";
        if (Time == 90) lyricsBox.text = "never gonna run around and desert you";
        if (Time == 94) lyricsBox.text = "never gonna make you cry";
        if (Time == 96) lyricsBox.text = "never gonna say goodbye";
        if (Time == 98) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (Time == 103) lyricsBox.text = "never gonna give you up";
        if (Time == 105) lyricsBox.text = "never gonna let you down";
        if (Time == 107) lyricsBox.text = "never gonna run around and desert you";
        if (Time == 111) lyricsBox.text = "never gonna make you cry";
        if (Time == 113) lyricsBox.text = "never gonna say goodbye";
        if (Time == 115) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (Time == 120) lyricsBox.text = "";
        if (Time == 129) lyricsBox.text = "never gonna give, never gonna give";
        if (Time == 131) lyricsBox.text = "";
        if (Time == 133) lyricsBox.text = "never gonna give, never gonna give";
        if (Time == 135) lyricsBox.text = "";
        if (Time == 137) lyricsBox.text = "we've known each other for so long";
        if (Time == 142) lyricsBox.text = "your heart's been aching, but";
        if (Time == 144) lyricsBox.text = "you're too shy to say it";
        if (Time == 146) lyricsBox.text = "inside, we both know what's been going on";
        if (Time == 150) lyricsBox.text = "we know the game and we're gonna play it";
        if (Time == 154) lyricsBox.text = "i just wanna tell you how i'm feeling";
        if (Time == 159) lyricsBox.text = "gotta make you understand";
        if (Time == 162) lyricsBox.text = "never gonna give you up";
        if (Time == 164) lyricsBox.text = "never gonna let you down";
        if (Time == 166) lyricsBox.text = "never gonna run around and desert you";
        if (Time == 170) lyricsBox.text = "never gonna make you cry";
        if (Time == 172) lyricsBox.text = "never gonna say goodbye";
        if (Time == 174) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (Time == 179) lyricsBox.text = "never gonna give you up";
        if (Time == 181) lyricsBox.text = "never gonna let you down";
        if (Time == 183) lyricsBox.text = "never gonna run around and desert you";
        if (Time == 187) lyricsBox.text = "never gonna make you cry";
        if (Time == 189) lyricsBox.text = "never gonna say goodbye";
        if (Time == 191) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (Time == 196) lyricsBox.text = "never gonna give you up";
        if (Time == 198) lyricsBox.text = "never gonna let you down";
        if (Time == 200) lyricsBox.text = "never gonna run around and desert you";
        if (Time == 204) lyricsBox.text = "never gonna make you cry";
        if (Time == 206) lyricsBox.text = "never gonna say goodbye";
        if (Time == 208) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (Time == 112) lyricsBox.text = "";

        currentLyric = lyricsBox.text;
        PlayerPrefs.SetString("currentLyric", currentLyric);
    }
}
