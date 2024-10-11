using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameSettingButton : MonoBehaviour
{
    private CharacterStat newCharacter = new CharacterStat();
    public InputField nameInputField;

    public void onClick()
    {
        if (nameInputField.text != "")
        {
            newCharacter = new CharacterStat(nameInputField.text, 10);
            GameManager.Instance.SetCharacter(newCharacter);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("ºóÄ­ ¾È´ï");
        }
    }
}
