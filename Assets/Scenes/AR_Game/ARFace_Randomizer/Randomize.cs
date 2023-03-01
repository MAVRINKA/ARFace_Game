using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomize : MonoBehaviour
{

    private Sprite[] diceSides;
    public SpriteRenderer sp;

    public Image img;
    public Text nameFac;

    public AudioSource audioS;
    //public AudioClip endRandom;

    public Button btnGo;

    private void Start()
    {
        diceSides = Resources.LoadAll<Sprite>("Image_Randomize");
    }

    public void RandomGo()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        int finalSide = 0;

        for(int i = 0; i <= 50; i++)
        {
            btnGo.interactable = false;

            randomDiceSide = Random.Range(0, diceSides.Length);

            sp.sprite = diceSides[randomDiceSide];

            nameFac.enabled = false;

            yield return new WaitForSeconds(0.05f);
        }

        finalSide = randomDiceSide + 1;

        Debug.Log(finalSide);

        nameFac.text = sp.sprite.name;
        nameFac.enabled = true;

        btnGo.interactable = true;
        audioS.Play();
    }

}
