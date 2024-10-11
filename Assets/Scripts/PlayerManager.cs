using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;
    public CharacterStat CurrentStat { get; private set; }

    public Text NameText;

    private void FloatNameTag()
    {
        NameText.transform.position = Camera.main.WorldToScreenPoint(transform.position) + new Vector3(0, 40, 0);
    }

    private void OnGUI()
    {
        FloatNameTag();
    }
}
