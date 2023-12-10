using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rd = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 vel = rd.velocity;
            vel.y = jumpForce;
            rd.velocity = vel;
        }
    }
}
