using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}

