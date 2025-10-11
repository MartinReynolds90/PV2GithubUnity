using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilRecto : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 30f)]
    private float speed = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direction = Vector2.left;
        rb.velocity = direction * speed;
    }

}
