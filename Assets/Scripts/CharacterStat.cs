using UnityEngine;

public class CharacterStat
{
    public string name;
    [Range(5, 10)] public float moveSpeed;

    public CharacterStat()
    {

    }

    public CharacterStat(string _name, float _moveSpeed)
    {
        name = _name;
        moveSpeed = _moveSpeed;
    }
}