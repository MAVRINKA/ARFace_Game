using System.Collections;
using UnityEngine;

public class MoveBird : MonoBehaviour
{
    public RectTransform[] points; // массив точек, по которым будет двигаться объект
    public float moveTime = 5f; // время, за которое объект должен пройти все точки
    public AudioSource audioSource; // объект AudioSource

    private int currentPoint = 0; // индекс текущей точки
    private float timer = 0f; // переменная для отслеживания времени

    void Start()
    {
        StartCoroutine(MoveToPoint());
    }

    IEnumerator MoveToPoint()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = points[currentPoint].position;

        while (timer < moveTime)
        {
            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, endPos, timer / moveTime);
            yield return null;
        }

        if (currentPoint < points.Length - 1)
        {
            currentPoint++;
            startPos = transform.position;
            endPos = points[currentPoint].position;
            timer = 0f;
            StartCoroutine(MoveToPoint());
        }
        else
        {
            // Здесь вы можете выполнить какие-либо дополнительные действия, когда объект достигнет последней точки
        }
    }

    void Update()
    {
        // Предположим, что трек уже проигрывается через AudioSource
        // Для синхронизации движения объекта с треком, вы можете использовать текущее время воспроизведения трека и плавно изменять tempo или скорость движения объекта, чтобы синхронизировать их движение
        // Например:
        // float audioPlaybackTime = audioSource.time;
        // Дальше вы можете использовать это значение для изменения скорости перемещения объекта
    }
}
