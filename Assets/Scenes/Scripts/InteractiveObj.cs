using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveObj : MonoBehaviour
{
    public Color colorObj;
    public Image img;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material.color = colorObj;
            FindObjectOfType<Player>().isJump = true;
            //FindObjectOfType<Player>().isJump = false;
            img.color = Color.yellow;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            FindObjectOfType<Player>().isJump = false;
            img.color = Color.white;
        }
    }


}
