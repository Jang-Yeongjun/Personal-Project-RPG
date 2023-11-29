using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void ChangeGoScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "ScreenScene")
        {
            SceneManager.LoadScene("MobileRPGStartScene");
        }
    }
    public void ChangeBackScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "MobileRPGMainScene")
        {
            SceneManager.LoadScene("MobileRPGStartScene");
        }
        else if(currentSceneName == "MobileRPGStartScene")
        {
            SceneManager.LoadScene("ScreenScene");
        }
        else if (currentSceneName == "ScreenScene")
        {
            SceneManager.LoadScene("PhoneScene");
        }
    }
}
