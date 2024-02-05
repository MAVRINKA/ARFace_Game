using System.Collections;
using UnityEngine;

public class MoveInSyncWithAudio : MonoBehaviour
{
    public RectTransform[] points; // массив точек, по которым будет двигаться объект
    public float moveTime = 5f; // время, за которое объект должен пройти все точки
    public AudioSource audioSource; // объект AudioSource

    private int currentPoint = 0; // индекс текущей точки

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
            float journeyTime = audioClipLength / (points.Length - 1); // Время, выделенное на каждый сегмент пути

            float fracJourney = (Time.time - startTime) / journeyTime;
            transform.position = Vector3.Lerp(points[currentPoint].position, points[currentPoint + 1].position, fracJourney);

            if (fracJourney >= 1.0f) // Проверка достижения следующей точки
            {
                currentPoint++;
                if (currentPoint < points.Length - 1)
                {
                    journeyLength = Vector3.Distance(points[currentPoint].position, points[currentPoint + 1].position);
                    startTime = Time.time;
                }
                else
                {
                    // Достигнута последняя точка. Можно выполнить дополнительные действия, если нужно.
                    yield break; // Выход из цикла
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
