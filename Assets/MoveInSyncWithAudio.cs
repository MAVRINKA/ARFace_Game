using System.Collections;
using UnityEngine;

public class MoveInSyncWithAudio : MonoBehaviour
{
    public RectTransform[] points; // ������ �����, �� ������� ����� ��������� ������
    public float moveTime = 5f; // �����, �� ������� ������ ������ ������ ��� �����
    public AudioSource audioSource; // ������ AudioSource

    private int currentPoint = 0; // ������ ������� �����

    void Start()
    {
        StartCoroutine(MoveToPointWithDuration());
    }

    IEnumerator MoveToPointWithDuration()
    {
        float audioClipLength = audioSource.clip.length;
        float journeyLength = Vector3.Distance(points[currentPoint].position, points[currentPoint + 1].position);
        float startTime = Time.time;

        while (currentPoint < points.Length - 1)
        {
            float journeyTime = audioClipLength / (points.Length - 1); // �����, ���������� �� ������ ������� ����

            float fracJourney = (Time.time - startTime) / journeyTime;
            transform.position = Vector3.Lerp(points[currentPoint].position, points[currentPoint + 1].position, fracJourney);

            if (fracJourney >= 1.0f) // �������� ���������� ��������� �����
            {
                currentPoint++;
                if (currentPoint < points.Length - 1)
                {
                    journeyLength = Vector3.Distance(points[currentPoint].position, points[currentPoint + 1].position);
                    startTime = Time.time;
                }
                else
                {
                    // ���������� ��������� �����. ����� ��������� �������������� ��������, ���� �����.
                    yield break; // ����� �� �����
                }
            }

            yield return null;
        }
    }

    public void OnPause()
    {
        Time.timeScale = 0;
    }

    public void OnPlay()
    {
        Time.timeScale = 1;
    }

    public void Reset()
    {
        currentPoint = 0;
        StopCoroutine(MoveToPointWithDuration());

    }
}
