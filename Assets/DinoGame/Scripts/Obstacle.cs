using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float leftEdge;

    private void Start()
    {
        leftEdge = 15f;
    }
    private void Update()
    {
        transform.position += GameManager.Instance.gameSpeed * Time.deltaTime * Vector3.right;

        if(transform.position.x > leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
