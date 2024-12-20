using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool potatoIsAlive=true;
    void Start()
    {
        if(myRigidbody == null)
            myRigidbody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)==true)&& potatoIsAlive ==true)
        { 
            if(myRigidbody != null) { 
                myRigidbody.velocity = Vector2.up * flapStrength;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        potatoIsAlive=false;
    }
}
