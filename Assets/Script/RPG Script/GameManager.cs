using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public GameObject selectScreen;
    public GameObject nameScreen;

    private void Start()
    {
        if (playerNameInput != null)
        {
            playerNameInput.onEndEdit.AddListener(SubmitInputName);
        }
        else
        {
            Debug.LogError("playerNameInput is null. Event listener not added.");
        }
    }

    private void SubmitInputName(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            PlayerPrefs.SetString("CurrentPlayerName", input);
            SceneManager.LoadScene("MobileRPGMainScene");
        }
        else
        {
            Debug.LogWarning("Player name is empty.");
        }
    }
    public void Onoffscreen()
    {
        if (!nameScreen.activeSelf)
        {
            selectScreen.SetActive(false);
            nameScreen.SetActive(true);
        }
        else if (!selectScreen.activeSelf)
        {
            selectScreen.SetActive(true);
            nameScreen.SetActive(false);
        }
    }
}
