﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public int index;
    public string LevelName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }

    
    
}
