using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController : MonoBehaviour
{

    public GameObject Mom;
    public Text ChatText; // 실제 채팅이 나오는 텍스트
    public Text CharacterName; // 캐릭터 이름이 나오는 텍스트


    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = "";

    bool isCrushed = false;


 
    void Start()
    {
        StartCoroutine(TextPractice());
    }


    void Update()
    {
        foreach (var element in skipButton) // 버튼 검사
        {
            if (Input.GetKeyDown(element))
            {
                isCrushed = true;
            }
        }
    }

    
    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        CharacterName.text = narrator;
        writerText = "";

        //텍스트 타이핑 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //키를 다시 누를 떄 까지 무한정 대기
        while (true)
        {
            if (isCrushed)
            {
                isCrushed = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("Jack", "                      "));
        yield return StartCoroutine(NormalChat("Mom", "아라리, 시장에 가서 소를 팔고 오너라."));
        yield return StartCoroutine(NormalChat("Jack", "네. 어머니."));
        yield return StartCoroutine(NormalChat("Jack", "                      "));
        yield return StartCoroutine(NormalChat("grandfa", "꼬마야, 그 소와 이 요술콩을 바꾸지 않겠니?"));
        yield return StartCoroutine(NormalChat("Jack", "요술콩이요?"));
        yield return StartCoroutine(NormalChat("grandfa", "이건 매우 신비로운 요술콩이란다."));
        yield return StartCoroutine(NormalChat("Jack", "네! 좋아요!"));
        yield return StartCoroutine(NormalChat("Jack", "                  "));
        yield return StartCoroutine(NormalChat("Mom", "아라리, 소 팔고온 돈은 어디있니?"));
        yield return StartCoroutine(NormalChat("Jack", "길 가다가 할아버지를 만나서 신비한 요술콩과 바꿔왔어요!"));
        yield return StartCoroutine(NormalChat("Mom", "요술콩? 그깟 콩이랑 소를 바꿔온거야?"));
        yield return StartCoroutine(NormalChat("Mom", "이런건 갖다 버리고 집이나 치워!!"));
        yield return StartCoroutine(NormalChat("Jack", "                       "));
                yield return StartCoroutine(NormalChat("Jack", "어??!! 이게 뭐지??"));
        yield return StartCoroutine(NormalChat("Jack", "올라가보자."));
        yield return StartCoroutine(NormalChat("Jack", "                    "));
    }
}
