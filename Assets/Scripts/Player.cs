using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.3454f;
    private bool dead;
    [SerializeField] private int health;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Game Dev");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;

        if (transform.position.x > 8.35f)
        {
            transform.position = new Vector3(8.35f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -8.35f)
        {
            transform.position = new Vector3(-8.35f, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 4.35f)
        {
            transform.position = new Vector3(transform.position.x, 4.35f, transform.position.z);
        }
        if (transform.position.y < -4.35f)
        {
            transform.position = new Vector3(transform.position.x, -4.35f, transform.position.z);
        }
    }
}
