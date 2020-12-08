using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice2 : MonoBehaviour
{
    //public string transferMapName;
    private Jack_Controller thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<Jack_Controller>();


    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "player")
        {
            //thePlayer.currentMapName = transferMapName;
            SceneManager.LoadScene("2choice");
        }
    }
}
