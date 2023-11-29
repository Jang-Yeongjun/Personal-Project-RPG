using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CharacterAnime : MonoBehaviour
{
    public Animator anim;
    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
            
        if (_controller == null)
        {
            anim.SetBool("IsRun", false);
        }
        else if (_controller != null)
        {
           anim.SetBool("IsRun", true);
        }
    }
}
