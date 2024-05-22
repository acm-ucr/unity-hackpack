using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float moveSpeed = 5;
    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.gravityScale = 0;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 verlocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            verlocity += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            verlocity += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            verlocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            verlocity += new Vector3(1, 0, 0);
        }
        rb.velocity = Vector3.Normalize(verlocity) * moveSpeed;
    }

}
