using System.Collections;
using UnityEngine;

public class MoveBird : MonoBehaviour
{
    public RectTransform[] points; // ������ �����, �� ������� ����� ��������� ������
    public float moveTime = 5f; // �����, �� ������� ������ ������ ������ ��� �����
    public AudioSource audioSource; // ������ AudioSource

    private int currentPoint = 0; // ������ ������� �����
    private float timer = 0f; // ���������� ��� ������������ �������

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
            // ����� �� ������ ��������� �����-���� �������������� ��������, ����� ������ ��������� ��������� �����
        }
    }

    void Update()
    {
        // �����������, ��� ���� ��� ������������� ����� AudioSource
        // ��� ������������� �������� ������� � ������, �� ������ ������������ ������� ����� ��������������� ����� � ������ �������� tempo ��� �������� �������� �������, ����� ���������������� �� ��������
        // ��������:
        // float audioPlaybackTime = audioSource.time;
        // ������ �� ������ ������������ ��� �������� ��� ��������� �������� ����������� �������
    }
}
