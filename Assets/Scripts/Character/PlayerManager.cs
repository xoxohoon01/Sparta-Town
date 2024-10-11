using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat = new CharacterStat();
    public Text NameText;

    public void SetStat(CharacterStat newStat)
    {
        baseStat = newStat;
        GetComponent<TopDownMovement>().SetSpeed(baseStat.moveSpeed);
    }

    //스탯이 바뀔 때 바뀐 값을 이동 스크립트 등에 뿌려주게 하기 위함.
    public void UpdateStat()
    {
        GetComponent<TopDownMovement>().SetSpeed(baseStat.moveSpeed);
    }

    private void FloatNameTag()
    {
        NameText.text = baseStat.name;
        NameText.transform.position = Camera.main.WorldToScreenPoint(transform.position) + new Vector3(0, 40, 0);
    }

    private void Update()
    {
        UpdateStat();
    }

    private void OnGUI()
    {
        FloatNameTag();
    }
}
