using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public bool counting;

    public void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "00:00.00";
    }

    public void Count()
    {
        counting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (counting)
        {
            timer += Time.deltaTime;
            float seconds = timer % 60;
            float minutes = timer / 60;
            GetComponent<TextMeshProUGUI>().text = minutes.ToString("00") + ":" + seconds.ToString("00.00");
        }
    }
}
