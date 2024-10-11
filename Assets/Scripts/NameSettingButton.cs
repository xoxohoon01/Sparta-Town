using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameSettingButton : MonoBehaviour
{
    public InputField nameInputField;

    public void onClick()
    {
        if (nameInputField.text != "")
        {
            GameManager.Instance.SetName(nameInputField.text);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("ºóÄ­ ¾È´ï");
        }
    }
}
