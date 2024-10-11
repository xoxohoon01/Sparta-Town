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
        // �κ񿡼� ������ ĳ���Ϳ� ���� ������ ����
        switch (GameManager.Instance.newCharacter.characterNumber)
        {
            case 0:
                newCharacter = Instantiate(Penguin);
                break;
            case 1:
                newCharacter = Instantiate(Cat);
                break;
        }

        // ������ ĳ���� �⺻���� ����
        newCharacter.GetComponent<PlayerManager>().SetStat(GameManager.Instance.newCharacter);
    }

    private void Start()
    {
        Spawn();
    }
}
