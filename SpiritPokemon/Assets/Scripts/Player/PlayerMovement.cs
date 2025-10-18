using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate (new Vector2(0, MoveSpeed));
            //rb.AddForce(new Vector2(0f, MoveSpeed * Time.deltaTime));
            rb.MovePosition(new Vector2(0, MoveSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -MoveSpeed));
            //rb.AddForce(new Vector2(0f, -MoveSpeed * Time.deltaTime));
             rb.MovePosition(new Vector2(0, -MoveSpeed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-MoveSpeed, 0));
            //rb.AddForce(new Vector2(MoveSpeed * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(MoveSpeed, 0));
            //rb.AddForce(new Vector2(-MoveSpeed * Time.deltaTime, 0f));
        }
    }
}
