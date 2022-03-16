using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField] public GameObject enemy;
    [SerializeField] public GameObject obstacle;
    [SerializeField] public GameObject booster;

    [SerializeField] public float deltaTime;
    [SerializeField] public float range;

    private float timer1 = 0;
    private float timer2 = 0;
    private float timer3 = 0;

    private void Start()
    {
        //add coroutines for obstacle spawn
    }

    void FixedUpdate()
    {
        //temporarry solution 

        if (timer1 > Random.Range(1f, deltaTime))
        {
            GameObject enemyClone = Instantiate(enemy);
            enemyClone.transform.position = transform.position + new Vector3(0, Random.Range(range, -range + 1), 0);

            timer1 = 0;
        }

        if (timer2 > Random.Range(1f, deltaTime))
        {
            GameObject obstacleClone = Instantiate(obstacle);
            obstacleClone.transform.position = transform.position + new Vector3(0, -3.4f, 0);

            timer2 = 0;
        }

        if (timer3 > Random.Range(1f, deltaTime))
        {
            GameObject boosterClone = Instantiate(booster);
            boosterClone.transform.position = transform.position + new Vector3(0, Random.Range(range, -range + 1), 0);

            timer3 = 0;
        }

        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
    }
}
