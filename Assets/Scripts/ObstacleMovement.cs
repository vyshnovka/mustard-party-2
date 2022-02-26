using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);
    }
}
