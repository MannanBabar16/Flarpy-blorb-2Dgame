using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButton(0)) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * 10;
        }

        if(transform.position.y < -17|| transform.position.y > 17) 
        {
            logic.gameOver();
        }

        //else if(transform.position.y > 17)
        //{
        //    logic.gameOver();
        //}

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
