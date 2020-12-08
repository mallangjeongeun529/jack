using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warning : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("StoryText");
    }
}
