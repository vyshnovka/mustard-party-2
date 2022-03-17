using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] public ObjectMovementScriptableObject objectMovementValues;

    private void Update()
    {
        transform.Translate(Vector3.left * objectMovementValues.runtimeSpeed * Time.deltaTime);
    }
}
