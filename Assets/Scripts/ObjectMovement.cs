using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] public ObjectMovementScriptableObject objectMovementValues;

    void Update()
    {
        transform.Translate(Vector3.left * objectMovementValues.speed * Time.deltaTime);
    }
}
