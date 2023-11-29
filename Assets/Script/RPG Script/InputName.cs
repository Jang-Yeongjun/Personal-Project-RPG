using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField inputName;

    public void Save()
    {
        PlayerPrefs.SetString("Name",inputName.name);
    }
}
