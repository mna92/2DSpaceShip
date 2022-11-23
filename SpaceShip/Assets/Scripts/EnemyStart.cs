using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStart : MonoBehaviour
{
    public Transform enemyLocation;
    public GameObject enemyGameObject;
    float respawnTimer = 0.5f;

    // Update is called once per frame
    void Update()
    {
        respawnTimer -= Time.deltaTime;
        enemyLocation.position = new Vector2(Random.Range(-2, 3), transform.position.y);
        if (respawnTimer <= 0)
        {
            Instantiate(enemyGameObject, transform.position, transform.rotation);
            respawnTimer = 0.5f;
        }
    }
}
