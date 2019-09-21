﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject character;
    public AudioClip soundClip;
    public AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("VRButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        character = GameObject.Find("Stacy");
        character.GetComponent<GameObject>();
        character.SetActive(false);

        soundSource.clip = soundClip;

    }

    public void OnButtonPressed(VirtualButtonBehaviour b)
    {
        if (character.activeSelf == true) {
            character.SetActive(false);
            soundSource.Stop();
        }
        else
        {
            character.SetActive(true);
            soundSource.PlayOneShot(soundClip);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour b)
    {
        //Do nothing
    }

    // Update is called once per frame
    void Update()
    {

    }
}
