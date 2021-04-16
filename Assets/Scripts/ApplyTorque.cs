using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyTorque : MonoBehaviour
{
    public enum ForceApplyInstant { Start, Always, Button };

    public ForceApplyInstant    when;
    public float                torque;
    public ForceMode2D          type;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (when == ForceApplyInstant.Start)
        {
            rb.AddTorque(torque, type);
        }
    }

    void FixedUpdate()
    {
        if (when == ForceApplyInstant.Always)
        {
            rb.AddTorque(torque, type);
        }
    }

    [Button("Apply Force")]
    void OnApplyForce()
    {
        if (when == ForceApplyInstant.Button)
        {
            rb.AddTorque(torque, type);
        }
    }
}
