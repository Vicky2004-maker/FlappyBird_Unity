using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    private float _speed = 1f;

    void Update()
    {
        transform.position += Vector3.left * (_speed * Time.deltaTime);
    }
}