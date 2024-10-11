using UnityEngine;

[System.Serializable]
public class CharacterStat
{
    public string name;
    public int characterNumber;
    [Range(10, 20)] public float moveSpeed = 10;

    public CharacterStat()
    {
        name = "아무개";
        moveSpeed = 10;
    }

    public CharacterStat(string _name, float _moveSpeed, int _characterNumber)
    {
        name = _name;
        moveSpeed = _moveSpeed;
    }
}