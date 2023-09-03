using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private float spawnRate = 3f;
    private float timer = 0f;
    [SerializeField] private float xOffset = 15f;

    void Start()
    {
        SpawnBall();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnBall();
            timer = 0;
        }
    }

    private void SpawnBall()
    {
        float leftMostPoint = transform.position.x - xOffset;
        float rightMostPoint = transform.position.x + xOffset;

        Instantiate(ball, new Vector3(Random.Range(leftMostPoint, rightMostPoint), transform.position.y, 0), transform.rotation);
    }
}
