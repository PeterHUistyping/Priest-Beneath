using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsActive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsActive)
        {
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
        Vector3 nowpos = gameObject.transform.position;
        if (Mathf.Abs(nowpos.x)>30 || Mathf.Abs(nowpos.y) > 17.7)
        {
            logic.gameOver();
            birdIsActive = false;
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsActive = false;
    }
}
