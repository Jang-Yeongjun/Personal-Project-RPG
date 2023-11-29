using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffbtn : MonoBehaviour
{
    public GameObject offscreen;
    public GameObject onscreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onoffscreen()
    {
        Debug.Log("nananana");
        if (!onscreen.activeSelf)
        {
            Debug.Log("sasasasa");
            offscreen.SetActive(false);
            onscreen.SetActive(true);
        }
        else if (!offscreen.activeSelf)
        {
            Debug.Log("dadadada");
            offscreen.SetActive(true);
            onscreen.SetActive(false);
        }
    }
}
