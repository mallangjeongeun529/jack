using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class typing02 : MonoBehaviour
{
    public Text tx;
    private string m_text = "너무나 게으른 소년이었던\n 아들 잭은 일을 하지않았어요.\n 그래서 그들은 항상 가난했답니다.";



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