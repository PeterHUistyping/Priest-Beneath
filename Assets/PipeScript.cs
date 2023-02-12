using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public int initial_health;
    private int current_health;
    public TMPro.TextMeshPro hp_label;

    public void set_health(int health) {
    }

    // Start is called before the first frame update
    void Start()
    {
        current_health = initial_health;
        hp_label = gameObject.GetComponentInChildren<TMPro.TextMeshPro>();
        hp_label.text = current_health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Bullet(Clone)")
        {
            Debug.Log("Bullet hit wall detected");
            int damage = collision.collider.GetComponentInParent<BulletScript>().bullet_damage;
            current_health -= damage;
            hp_label.text = current_health.ToString();
            if (current_health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
