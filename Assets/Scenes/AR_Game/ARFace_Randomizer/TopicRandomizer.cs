using UnityEngine;
using System.Collections.Generic;

public class TopicRandomizer : MonoBehaviour
{
    public List<string> topics = new List<string> { "Гриффиндор", "Слизерин", "Пуффендуй", "Когтевран" };
    public List<string> chosenTopics = new List<string>();
    public int operationsCount = 30;
    public int perTopicCount;

    void Start()
    {
        perTopicCount = operationsCount * topics.Count;
        // В этом примере я считаю, что у вас есть какой-то способ запуска рандомизации, например кнопка
    }

    public void RandomizeTopic()
    {
        if (operationsCount > 0)
        {
            if (chosenTopics.Count < topics.Count * perTopicCount)
            {
                int randomIndex = Random.Range(0, topics.Count);
                string selectedTopic = topics[randomIndex];
                chosenTopics.Add(selectedTopic);
                operationsCount--;
                if (chosenTopics.Count % perTopicCount == 0)
                {
                    topics.RemoveAt(randomIndex);
                }
                Debug.Log("Выбранная тема: " + selectedTopic);
            }
            else
            {
                Debug.Log("Все темы уже были выбраны");
                // Здесь можно сбросить списки и начать заново, если это необходимо
            }
        }
        else
        {
            Debug.Log("Все операции завершены");
        }
    }
}