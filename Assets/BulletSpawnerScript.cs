using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour
{
    public GameObject bullet;
    public double spawnInterval;
    private float timer = 0;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spawnBullet();
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval = 1 / logic.bullet_frequency;
        logic.bullet_frequency += 0.002;
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBullet();
            timer = 0;
        }

    }
    void spawnBullet()
    {
        GameObject new_bullet = Instantiate(bullet, transform.position, transform.rotation);
        new_bullet.GetComponent<BulletScript>().bullet_damage = logic.bullet_reference_damage;
        //logic.bullet_reference_damage++;
    }
}
