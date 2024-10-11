using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterPanelButton : MonoBehaviour
{
    public int characterNumber;
    public void onClick()
    {
        // ĳ���� ���� �� �г� �ݱ�
        GameManager.Instance.newCharacter.characterNumber = characterNumber;

        if (LobbySceneManager.Instance.SelectCharacterButton.transform.childCount > 0)
        {
            for (int i = 0; i < LobbySceneManager.Instance.SelectCharacterButton.transform.childCount; i++)
            {
                LobbySceneManager.Instance.SelectCharacterButton.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        LobbySceneManager.Instance.SelectCharacterButton.transform.GetChild(characterNumber).gameObject.SetActive(true);

        transform.parent.gameObject.SetActive(false);
    }
}
