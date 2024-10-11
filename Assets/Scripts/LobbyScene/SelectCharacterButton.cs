using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacterButton : MonoBehaviour
{
    public GameObject SelectCharacterPanel;

    public void onClick()
    {
        SelectCharacterPanel.SetActive(true);
    }
}
