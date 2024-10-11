using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    public InputField nameInputField;

    public void onClick()
    {
        // �̸��� ��ĭ�� �ƴ� ���
        if (nameInputField.text != "")
        {
            GameManager.Instance.newCharacter.name = nameInputField.text;
            SceneManager.LoadScene("MainScene");
        }

        // �̸��� ��ĭ�� ���
        else
        {
            Debug.Log("��ĭ �ȴ�");
        }
    }
}
