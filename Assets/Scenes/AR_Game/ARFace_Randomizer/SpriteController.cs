using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;

public class SpriteController : MonoBehaviour
{
    public Sprite[] allSprites; // ������ �� ����� ���������
    public List<Sprite> remainingSprites; // ������ ���������� ��������
    public List<Sprite> shownSprites; // ������ ���������� ��������

    public Image img;
    public Button btnGo;

    public AudioSource audioS;

    private void Start()
    {
        remainingSprites = new List<Sprite>(allSprites);
        shownSprites = new List<Sprite>();
    }

    public void RandomGo()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        for (int i = 0; i <= 50; i++)
        {
            btnGo.interactable = false;

            randomDiceSide = Random.Range(0, allSprites.Length);

            img.sprite = allSprites[randomDiceSide];

            yield return new WaitForSeconds(0.05f);
        }

        ShowRandomSprite();

        btnGo.interactable = true;
        audioS.Play();
    }

    public void ShowRandomSprite()
    {
        if (remainingSprites.Count > 0)
        {
            int randomIndex = Random.Range(0, remainingSprites.Count);
            Sprite randomSprite = remainingSprites[randomIndex];

            // ����������� randomSprite �� Canvas
            img.sprite = randomSprite;

            remainingSprites.RemoveAt(randomIndex);
            shownSprites.Add(randomSprite);
        }
        else
        {
            // ��� ������� ���� ��������, ������ ����� �������� ������
            ResetSpriteLists();
        }
    }

    private void ResetSpriteLists()
    {
        remainingSprites.AddRange(shownSprites); // ��������� ��� ���������� ������� ������� � ������ ����������
        shownSprites.Clear(); // ������� ������ ���������� ��������
        ShowRandomSprite(); // ���������� ��������� ��������� ������
    }
}
