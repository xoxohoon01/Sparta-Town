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
        // ÀÌ¸§ÀÌ ºóÄ­ÀÌ ¾Æ´Ñ °æ¿ì
        if (nameInputField.text != "")
        {
            GameManager.Instance.newCharacter.name = nameInputField.text;
            SceneManager.LoadScene("MainScene");
        }

        // ÀÌ¸§ÀÌ ºóÄ­ÀÎ °æ¿ì
        else
        {
            Debug.Log("ºóÄ­ ¾È´ï");
        }
    }
}
