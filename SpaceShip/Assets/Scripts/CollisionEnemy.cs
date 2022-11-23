using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public GameObject explosionAnimation;

    private void OnCollisionEnter2D(Collision2D gameCollision)
    {
        if (gameCollision.gameObject.tag == "space")
        {
            Destroy(gameObject);
            Instantiate(explosionAnimation, transform.position, Quaternion.identity);
            gameCollision.gameObject.GetComponent<HealthManager>().DecreaseHealth(10);
        }

        if (gameCollision.gameObject.tag == "bullet1")
        {
            Destroy(gameObject);
            Destroy(gameCollision.gameObject);
            Instantiate(explosionAnimation, transform.position, Quaternion.identity);
        }
    }
}
