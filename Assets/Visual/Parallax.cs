using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float length, start_position;
    public float parallex_effect;
    public float move_speed = 5;

    void Start()
    {
        start_position = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {

        transform.position = transform.position + (Vector3.left * move_speed) * Time.deltaTime * (1-parallex_effect);
        if (transform.position.x > start_position + length) transform.position = transform.position + (Vector3.left * length);
        else if (transform.position.x < start_position - length) transform.position = transform.position + (Vector3.right * length);
    }
}
