using UnityEngine;
using System.Collections.Generic;

public class TopicRandomizer : MonoBehaviour
{
    public List<string> topics = new List<string> { "����������", "��������", "���������", "���������" };
    public List<string> chosenTopics = new List<string>();
    public int operationsCount = 30;
    public int perTopicCount;

    void Start()
    {
        perTopicCount = operationsCount * topics.Count;
        // � ���� ������� � ������, ��� � ��� ���� �����-�� ������ ������� ������������, �������� ������
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
                Debug.Log("��������� ����: " + selectedTopic);
            }
            else
            {
                Debug.Log("��� ���� ��� ���� �������");
                // ����� ����� �������� ������ � ������ ������, ���� ��� ����������
            }
        }
        else
        {
            Debug.Log("��� �������� ���������");
        }
    }
}