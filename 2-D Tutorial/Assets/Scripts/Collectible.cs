﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    private AudioSource audioSource;

    private void Start()
    {
        
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();

           // Destroy(gameObject);
        }
    }
    // Use this for initialization
    
}
