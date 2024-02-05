using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;

public class SpriteController : MonoBehaviour
{
    public Sprite[] allSprites; // массив со всеми спрайтами
    public List<Sprite> remainingSprites; // список оставшихся спрайтов
    public List<Sprite> shownSprites; // список показанных спрайтов

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

            // Отображение randomSprite на Canvas
            img.sprite = randomSprite;

            remainingSprites.RemoveAt(randomIndex);
            shownSprites.Add(randomSprite);
        }
        else
        {
            // Все спрайты были показаны, теперь нужно обновить список
            ResetSpriteLists();
        }
    }

    private void ResetSpriteLists()
    {
        remainingSprites.AddRange(shownSprites); // добавляем уже показанные спрайты обратно в список оставшихся
        shownSprites.Clear(); // очищаем список показанных спрайтов
        ShowRandomSprite(); // показываем следующий рандомный спрайт
    }
}
