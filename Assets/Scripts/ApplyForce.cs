using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public enum ForceApplyInstant { Start, Always, Button };

    public ForceApplyInstant    when;
    public Vector2              force;
    public ForceMode2D          type;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (when == ForceApplyInstant.Start)
        {
            rb.AddForce(force);
        }
    }

    void FixedUpdate()
    {
        if (when == ForceApplyInstant.Always)
        {
            rb.AddForce(force);
        }
    }

    [Button("Apply Force")]
    void OnApplyForce()
    {
        if (when == ForceApplyInstant.Button)
        {
            rb.AddForce(force);
        }
    }
}
