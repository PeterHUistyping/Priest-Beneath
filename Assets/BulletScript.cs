using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone;
    public int bullet_damage;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        if (transform.position.x > deadZone)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
            return;
        Destroy(gameObject);
    }
}
