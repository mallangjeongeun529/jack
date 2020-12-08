using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTest : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("choice");
    }
}
