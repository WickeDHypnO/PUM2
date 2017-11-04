using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    public List<TextMeshProUGUI> levelTimes;

    void OnEnable () {
		foreach(TextMeshProUGUI text in levelTimes)
        {
            if(PlayerPrefs.HasKey(text.name))
            {
                float time = PlayerPrefs.GetFloat(text.name);
                float seconds = time % 60;
                float minutes = time / 60;
                text.text = minutes.ToString("00") + ":" + seconds.ToString("00.00");
            }
        }
	}
}
