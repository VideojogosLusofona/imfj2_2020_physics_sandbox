using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTrajectory : MonoBehaviour
{
    public float trajectoryDuration = 2;

    Vector2 startPosition;

    ApplyVelocity   applyVelocity;
    ApplyForce      applyForce;
    Rigidbody2D     rigidBody;

    void Start()
    {
        startPosition = transform.position;

        rigidBody = GetComponent<Rigidbody2D>();
        applyVelocity = GetComponent<ApplyVelocity>();
        applyForce = GetComponent<ApplyForce>();
    }

    void Update()
    {
        float   elapsedTime = 0;
        Vector3 prevPos = startPosition;
        while (elapsedTime < trajectoryDuration)
        {
            Vector3 currentPos = ComputePosition(elapsedTime);

            Debug.DrawLine(prevPos, currentPos);

            prevPos = currentPos;
            elapsedTime += Time.fixedDeltaTime;
        }
    }

    Vector2 ComputePosition(float time)
    {
        if (applyVelocity)
        {
            // Este é fácil...
        }
        else if (applyForce)
        {
            // Este é mais difícil!
        }

        return startPosition;
    }
}
