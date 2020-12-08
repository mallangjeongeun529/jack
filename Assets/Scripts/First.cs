using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class First : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("StoryMenu");
    }
}