using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : PhysicsObject
{
    [SerializeField]
    private int maxSpeed = 8;
    [SerializeField]
    private int jumpPower = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal"), 0) * maxSpeed;

        if (Input.GetButton("Jump") && grounded)
        {
            velocity.y = jumpPower;
        }
    }
}
