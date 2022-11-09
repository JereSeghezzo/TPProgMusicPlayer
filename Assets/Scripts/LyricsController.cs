using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LyricsController : MonoBehaviour
{
    public Text lyricsBox;

    void Awake()
    {
        lyricsBox.text = PlayerPrefs.GetString("currentLyric");
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("timeCounter") == 0) lyricsBox.text = "";
        if (PlayerPrefs.GetInt("timeCounter") == 19) lyricsBox.text = "we're no strangers to love";
        if (PlayerPrefs.GetInt("timeCounter") == 23) lyricsBox.text = "you know the rules and so do i";
        if (PlayerPrefs.GetInt("timeCounter") == 27) lyricsBox.text = "a full commitment's what i'm thinking of";
        if (PlayerPrefs.GetInt("timeCounter") == 32) lyricsBox.text = "you wouldn't get this from any other guy";
        if (PlayerPrefs.GetInt("timeCounter") == 36) lyricsBox.text = "i just wanna tell you how i'm feeling";
        if (PlayerPrefs.GetInt("timeCounter") == 41) lyricsBox.text = "gotta make you understand";
        if (PlayerPrefs.GetInt("timeCounter") == 44) lyricsBox.text = "never gonna give you up";
        if (PlayerPrefs.GetInt("timeCounter") == 46) lyricsBox.text = "never gonna let you down";
        if (PlayerPrefs.GetInt("timeCounter") == 48) lyricsBox.text = "never gonna run around and desert you";
        if (PlayerPrefs.GetInt("timeCounter") == 52) lyricsBox.text = "never gonna make you cry";
        if (PlayerPrefs.GetInt("timeCounter") == 54) lyricsBox.text = "never gonna say goodbye";
        if (PlayerPrefs.GetInt("timeCounter") == 56) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (PlayerPrefs.GetInt("timeCounter") == 60) lyricsBox.text = "";
        if (PlayerPrefs.GetInt("timeCounter") == 61) lyricsBox.text = "we've known each other for so long";
        if (PlayerPrefs.GetInt("timeCounter") == 65) lyricsBox.text = "your heart's been aching, but";
        if (PlayerPrefs.GetInt("timeCounter") == 68) lyricsBox.text = "you're too shy to say it";
        if (PlayerPrefs.GetInt("timeCounter") == 70) lyricsBox.text = "inside, we both know what's been going on";
        if (PlayerPrefs.GetInt("timeCounter") == 74) lyricsBox.text = "we know the game and we're gonna play it";
        if (PlayerPrefs.GetInt("timeCounter") == 78) lyricsBox.text = "and if you ask me how i'm feeling";
        if (PlayerPrefs.GetInt("timeCounter") == 83) lyricsBox.text = "don't tell me you're too blind to see";
        if (PlayerPrefs.GetInt("timeCounter") == 86) lyricsBox.text = "never gonna give you up";
        if (PlayerPrefs.GetInt("timeCounter") == 88) lyricsBox.text = "never gonna let you down";
        if (PlayerPrefs.GetInt("timeCounter") == 90) lyricsBox.text = "never gonna run around and desert you";
        if (PlayerPrefs.GetInt("timeCounter") == 94) lyricsBox.text = "never gonna make you cry";
        if (PlayerPrefs.GetInt("timeCounter") == 96) lyricsBox.text = "never gonna say goodbye";
        if (PlayerPrefs.GetInt("timeCounter") == 98) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (PlayerPrefs.GetInt("timeCounter") == 103) lyricsBox.text = "never gonna give you up";
        if (PlayerPrefs.GetInt("timeCounter") == 105) lyricsBox.text = "never gonna let you down";
        if (PlayerPrefs.GetInt("timeCounter") == 107) lyricsBox.text = "never gonna run around and desert you";
        if (PlayerPrefs.GetInt("timeCounter") == 111) lyricsBox.text = "never gonna make you cry";
        if (PlayerPrefs.GetInt("timeCounter") == 113) lyricsBox.text = "never gonna say goodbye";
        if (PlayerPrefs.GetInt("timeCounter") == 115) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (PlayerPrefs.GetInt("timeCounter") == 120) lyricsBox.text = "";
        if (PlayerPrefs.GetInt("timeCounter") == 129) lyricsBox.text = "never gonna give, never gonna give";
        if (PlayerPrefs.GetInt("timeCounter") == 131) lyricsBox.text = "";
        if (PlayerPrefs.GetInt("timeCounter") == 133) lyricsBox.text = "never gonna give, never gonna give";
        if (PlayerPrefs.GetInt("timeCounter") == 135) lyricsBox.text = "";
        if (PlayerPrefs.GetInt("timeCounter") == 137) lyricsBox.text = "we've known each other for so long";
        if (PlayerPrefs.GetInt("timeCounter") == 142) lyricsBox.text = "your heart's been aching, but";
        if (PlayerPrefs.GetInt("timeCounter") == 144) lyricsBox.text = "you're too shy to say it";
        if (PlayerPrefs.GetInt("timeCounter") == 146) lyricsBox.text = "inside, we both know what's been going on";
        if (PlayerPrefs.GetInt("timeCounter") == 150) lyricsBox.text = "we know the game and we're gonna play it";
        if (PlayerPrefs.GetInt("timeCounter") == 154) lyricsBox.text = "i just wanna tell you how i'm feeling";
        if (PlayerPrefs.GetInt("timeCounter") == 159) lyricsBox.text = "gotta make you understand";
        if (PlayerPrefs.GetInt("timeCounter") == 162) lyricsBox.text = "never gonna give you up";
        if (PlayerPrefs.GetInt("timeCounter") == 164) lyricsBox.text = "never gonna let you down";
        if (PlayerPrefs.GetInt("timeCounter") == 166) lyricsBox.text = "never gonna run around and desert you";
        if (PlayerPrefs.GetInt("timeCounter") == 170) lyricsBox.text = "never gonna make you cry";
        if (PlayerPrefs.GetInt("timeCounter") == 172) lyricsBox.text = "never gonna say goodbye";
        if (PlayerPrefs.GetInt("timeCounter") == 174) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (PlayerPrefs.GetInt("timeCounter") == 179) lyricsBox.text = "never gonna give you up";
        if (PlayerPrefs.GetInt("timeCounter") == 181) lyricsBox.text = "never gonna let you down";
        if (PlayerPrefs.GetInt("timeCounter") == 183) lyricsBox.text = "never gonna run around and desert you";
        if (PlayerPrefs.GetInt("timeCounter") == 187) lyricsBox.text = "never gonna make you cry";
        if (PlayerPrefs.GetInt("timeCounter") == 189) lyricsBox.text = "never gonna say goodbye";
        if (PlayerPrefs.GetInt("timeCounter") == 191) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (PlayerPrefs.GetInt("timeCounter") == 196) lyricsBox.text = "never gonna give you up";
        if (PlayerPrefs.GetInt("timeCounter") == 198) lyricsBox.text = "never gonna let you down";
        if (PlayerPrefs.GetInt("timeCounter") == 200) lyricsBox.text = "never gonna run around and desert you";
        if (PlayerPrefs.GetInt("timeCounter") == 204) lyricsBox.text = "never gonna make you cry";
        if (PlayerPrefs.GetInt("timeCounter") == 206) lyricsBox.text = "never gonna say goodbye";
        if (PlayerPrefs.GetInt("timeCounter") == 208) lyricsBox.text = "never gonna tell a lie and hurt you";
        if (PlayerPrefs.GetInt("timeCounter") == 112) lyricsBox.text = "";

        PlayerPrefs.SetString("currentLyric", lyricsBox.text);
    }
}
