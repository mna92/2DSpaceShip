using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float x, y;
    public float xSpeed, ySpeed;
    public GameObject bullet;
    public Transform bulletLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;
        if (Input.GetKey(KeyCode.A) && x >= -2)
        {
            x -= xSpeed;
        }
        if (Input.GetKey(KeyCode.D) && x <= 2)
        {
            x += xSpeed;
        }
        if (Input.GetKey(KeyCode.W) && y <= -1)
        {
            y += ySpeed;
        }
        if (Input.GetKey(KeyCode.S) && y >= -4)
        {
            y -= ySpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, bulletLocation.position, Quaternion.identity);
        }

        transform.position = new Vector2(x, y);
    }
}
