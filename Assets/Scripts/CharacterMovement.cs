using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float movementForce = 10f;

    private Rigidbody2D characterRigidbody;

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bool pressActive = Input.GetMouseButton(0);

        if (pressActive)
        {
            characterRigidbody.AddForce(new Vector2(0, movementForce));
        }
    }
}
