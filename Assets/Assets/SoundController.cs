using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        DestroyAnotherObjects();
        audioSource.Play();
    }

    private void DestroyAnotherObjects()
    {
       GameObject[] objects = GameObject.FindGameObjectsWithTag("SoundController");
        if (objects.Length == 1) return;

        if (!objects.Equals(gameObject))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
