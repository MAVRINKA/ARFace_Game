using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector3 direction;

    public float gravity = 20f;
    public float jumpForce = 8f;

    public bool isJump = false;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;

        if (character.isGrounded && isJump)
        {
            JumpDino();
        }

        character.Move(direction * Time.deltaTime);
    }

    public void JumpDino()
    {
        direction = Vector3.down;
        direction = Vector3.up * jumpForce;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
