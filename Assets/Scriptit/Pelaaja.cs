﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelaaja : MonoBehaviour
{
    private GameObject triggeringNpc;
    private bool triggering;

    public GameObject npcText;


    void Update()
    {
        if(triggering)
        {
            npcText.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                Destroy(triggeringNpc);
                triggering = false;
            }
        } else
        {
            npcText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        triggering = false;
        triggeringNpc = null;
    }
}
