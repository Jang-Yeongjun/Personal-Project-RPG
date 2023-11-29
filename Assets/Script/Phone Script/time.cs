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
        // ���� ��¥�� �ð��� �����ɴϴ�.
        DateTime currentTime = DateTime.Now;

        // �ð��� ���ϴ� �������� ǥ���մϴ�.
        string formattedTime = currentTime.ToString("HH:mm:ss");

        // UI Text�� ǥ���մϴ�.
        daytime.text = "���� �ð�: " + formattedTime;
    }
}
