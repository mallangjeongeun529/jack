using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class EndTyping : MonoBehaviour
{
    public Text tx;
    private string m_text = "황금알을 낳는 거위를 얻어 \n 부자가 된 아라리와 엄마는 \n 행복하게 살았답니다.";



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