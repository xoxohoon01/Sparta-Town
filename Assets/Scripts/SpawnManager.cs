using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Player;
    private void Start()
    {
        GameObject newCharacter = Instantiate(Player);
        newCharacter.GetComponent<PlayerManager>().SetStat(GameManager.Instance.newCharacter);
    }
}
