using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{

    public string startPoint;//플레이어 시작위치
    private Jack_Controller thePlayer;

    // Start is called before the first frame update
    void Start()
    {

        thePlayer = FindObjectOfType<Jack_Controller>();

        if (startPoint == thePlayer.currentMapName)
        {
            thePlayer.transform.position = this.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
