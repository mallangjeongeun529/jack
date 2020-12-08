using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class typing03 : MonoBehaviour
{
    public Text tx;
    private string m_text = "더 이상 먹고 살 돈이 없었던\n 엄마와 잭은 \n소를 팔기로 결정 했어요!";
   



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