using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Game Dev");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
    }
}