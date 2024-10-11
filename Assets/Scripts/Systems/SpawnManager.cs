using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Penguin;
    public GameObject Cat;
    GameObject newCharacter;

    public void Spawn()
    {
        // 로비에서 선택한 캐릭터에 따라 프리팹 생성
        switch (GameManager.Instance.newCharacter.characterNumber)
        {
            case 0:
                newCharacter = Instantiate(Penguin);
                break;
            case 1:
                newCharacter = Instantiate(Cat);
                break;
        }

        // 생성된 캐릭터 기본스텟 설정
        newCharacter.GetComponent<PlayerManager>().SetStat(GameManager.Instance.newCharacter);
    }

    private void Start()
    {
        Spawn();
    }
}
