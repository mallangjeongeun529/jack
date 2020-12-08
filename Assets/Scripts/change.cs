using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class change : MonoBehaviour
{
    public string transferMapName;
    private Jack_Controller thePlayer;
    void Start()
    {
        thePlayer = FindObjectOfType<Jack_Controller>();
    }

    void Update()
    {

    }

    public void ChangeGameScene()
    {
        
            thePlayer.currentMapName = transferMapName;
            SceneManager.LoadScene(transferMapName);
        
       
    }
}