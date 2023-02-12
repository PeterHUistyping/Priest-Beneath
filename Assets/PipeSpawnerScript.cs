using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=3;
    private float timer = 0;
    public float heightOffset = 6;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
   
    }
    void spawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;
        GameObject new_pipes = 
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), transform.position.z),transform.rotation);
        new_pipes.transform.GetChild(0).GetComponent<PipeScript>().initial_health = logic.wall_reference_hp;
        new_pipes.transform.GetChild(1).GetComponent<PipeScript>().initial_health = logic.wall_reference_hp;
        logic.wall_reference_hp = (int)(logic.wall_reference_hp * 1.5);
        logic.wall_move_speed += 2;
    }
}
