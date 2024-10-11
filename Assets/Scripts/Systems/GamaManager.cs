using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }

    public CharacterStat newCharacter;

    public void SetCharacter(CharacterStat _character)
    {
        newCharacter = _character;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            newCharacter = new CharacterStat();
        }
        else if (instance != this)
            Destroy(gameObject);
    }
    private void Start()
    {
    }
}
