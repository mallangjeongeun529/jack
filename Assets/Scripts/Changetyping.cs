﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Changetyping : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("StoryText02");
    }
}