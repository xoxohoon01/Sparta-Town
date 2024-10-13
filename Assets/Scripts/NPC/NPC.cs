using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Text msg;

    public void ShowMsg()
    {
        msg.gameObject.SetActive(true);
        
    }
    public void HideMsg()
    {
        msg.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShowMsg();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        HideMsg();
    }

    private void Update()
    {
        msg.transform.position = Camera.main.WorldToScreenPoint(transform.position + (4.5f * Vector3.up));
    }
}
