using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;

    public Text NameText;

    public void SetStat(CharacterStat newStat)
    {
        baseStat = newStat;
    }

    private void FloatNameTag()
    {
        NameText.text = baseStat.name;
        NameText.transform.position = Camera.main.WorldToScreenPoint(transform.position) + new Vector3(0, 40, 0);
    }

    private void OnGUI()
    {
        FloatNameTag();
    }
}
