using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.3454f;
    private bool dead;
    [SerializeField] private int health;
    [SerializeField] private float recoveryCounter;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Game Dev");
        health = 30;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
        recoveryCounter += Time.deltaTime;
        CheckBoundaries();
    }

    private void CheckBoundaries()
    {
        if (transform.position.x >= 8.35f)
        {
            transform.position = new Vector3(8.35f, transform.position.y, transform.position.z);
            Hurt();
        }
        if (transform.position.x <= -8.35f)
        {
            transform.position = new Vector3(-8.35f, transform.position.y, transform.position.z);
            Hurt();
        }
        if (transform.position.y >= 4.35f)
        {
            transform.position = new Vector3(transform.position.x, 4.35f, transform.position.z);
            Hurt();
        }
        if (transform.position.y <= -4.35f)
        {
            transform.position = new Vector3(transform.position.x, -4.35f, transform.position.z);
            Hurt();
        }
    }

    public void Hurt()
    {
        if (recoveryCounter > 2)
        {
            health -= 1;
            recoveryCounter = 0;
        }
    }
}
