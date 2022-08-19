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
    }
}
