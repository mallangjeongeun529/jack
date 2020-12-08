using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class typing01 : MonoBehaviour
{
    public Text tx;
    private string m_text = "옛날 옛적\n 한 마을에 가난뱅이 \n엄마와 아들이 살았습니다.";



    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
       // yield return new WaitForSeconds(2f);
        for (int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.1f);
        }


    }
}