using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBehaviour : MonoBehaviour
{
    float movementSpeed = 0.10f;
    // Start is called before the first frame update
    public float MoveSpeed= 5;
    public float  SteerSpeed= 180;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        float SteerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * SteerDirection * SteerSpeed * Time.deltaTime);
        /*
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(-movementSpeed, 0, 0);
        }
        */
    }
}
