﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
