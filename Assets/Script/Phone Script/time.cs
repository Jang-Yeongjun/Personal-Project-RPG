using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{
    public Text daytime;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTime();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }
    private void UpdateTime()
    {
        // 현재 날짜와 시간을 가져옵니다.
        DateTime currentTime = DateTime.Now;

        // 시간을 원하는 형식으로 표시합니다.
        string formattedTime = currentTime.ToString("HH:mm:ss");

        // UI Text에 표시합니다.
        daytime.text = "현재 시간: " + formattedTime;
    }
}
