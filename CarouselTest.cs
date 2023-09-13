
using System;
using UnityEngine;

public class CarouselTest : MonoBehaviour
{
    private Rigidbody rigidBody;
    private bool isRotating;
    private float rotationSpeed = 100.0f;
    private float currentRotationSpeed = 100.0f;
    private float duration = 4.0f;

  //  public AnimationCurve curve;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isRotating)
        {
            if (currentRotationSpeed > 0)
            {
                float decreaseAmount = rotationSpeed * Time.deltaTime / duration;
                currentRotationSpeed -= decreaseAmount;
                if (currentRotationSpeed < 0)
                {
                    currentRotationSpeed = 0;
                }
            }

            rigidBody.transform.Rotate(Vector3.up, currentRotationSpeed * Time.deltaTime);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        rigidBody.transform.Rotate(Vector3.up, currentRotationSpeed * Time.deltaTime);
    }

    void OnCollisionExit(Collision collision)
    {
        if (!isRotating)
        {
            isRotating = true;
            Invoke("StopRotation", duration);
        }
    }

    void StopRotation()
    {
        isRotating = false;
        currentRotationSpeed = rotationSpeed;
    }
}