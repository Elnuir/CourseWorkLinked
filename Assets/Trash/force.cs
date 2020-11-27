using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
Rigidbody2D circle;
    // Start is called before the first frame update
    void Start()
    {
        circle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        circle.velocity = new Vector2(20, 0);
    }
}
