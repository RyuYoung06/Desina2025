using UnityEngine;

public class Dessina : MonoBehaviour
{
    public int gold = 0;                      //정수형
    public float Hp = 100.0f;                   //실수형 (소수점이 있는 순자, 끝에 'f' 필수)
    public string playerName = "홍길동";      //문자열 (문자의 집합)
    private bool isAlive = true;              //논리형(참/거짓을 나타냄냄)


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("게임 시작");             //유니티 디버그에 메세지를 출력


        if (gold > 50)
        {
            Debug.Log("아이템을 구매할 수 있습니다.");
        }
        else if(gold > 25)
        {
            Debug.Log("일부 아이템을 구매할 수 있습니다.");
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("게임 진행중");             //유니티 디버그에 메세지를 출력

        if(Input.GetKeyDown(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("현재 골드 : " + gold);
        }
    }
}
