using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyVelocity : MonoBehaviour
{
    public enum ForceApplyInstant { Start, Always, Button };

    public ForceApplyInstant    when;
    public Vector2              velocity;
    public bool                 onlyApplyX;

    Rigidbody2D rb;
    Vector2     initialPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (when == ForceApplyInstant.Start)
        {
            var newVelocity = velocity;
            if (onlyApplyX) newVelocity.y = rb.velocity.y;
            rb.velocity = newVelocity;
        }

        initialPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (when == ForceApplyInstant.Always)
        {
            var newVelocity = velocity;
            if (onlyApplyX) newVelocity.y = rb.velocity.y;
            rb.velocity = newVelocity;
        }
    }

    [Button("Apply Velocity")]
    void OnApplyForce()
    {
        if (when == ForceApplyInstant.Button)
        {
            var newVelocity = velocity;
            if (onlyApplyX) newVelocity.y = rb.velocity.y;
            rb.velocity = newVelocity;
        }
    }
}
