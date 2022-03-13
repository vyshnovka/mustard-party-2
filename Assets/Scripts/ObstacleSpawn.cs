using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] public GameObject obstacle;

    [SerializeField] public float deltaTime;
    [SerializeField] public float range;

    private float timer;

    void Update()
    {
        if (timer > deltaTime)
        {
            GameObject obstacleClone = Instantiate(obstacle);
            obstacleClone.transform.position = transform.position + new Vector3(0, Random.Range(-range, range), 0);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
