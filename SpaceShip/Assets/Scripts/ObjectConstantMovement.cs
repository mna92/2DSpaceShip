using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectConstantMovement : MonoBehaviour
{
    public float ySpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);
    }
}
