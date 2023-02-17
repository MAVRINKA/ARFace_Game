using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Vector3 speed;

    [SerializeField]
    private float destroyAfterDead = 1.0f;

    void Update() 
    {
        transform.position += speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name == "Mouth")
        {
            UIManager.Instance.IncrementScore();
            Destroy(gameObject, destroyAfterDead);
        }
    }
}
