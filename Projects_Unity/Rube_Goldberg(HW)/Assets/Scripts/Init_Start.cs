using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Start : MonoBehaviour
{
    Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.Sleep();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.WakeUp();
        }
    }
}
