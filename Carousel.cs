using System.Collections;
using UnityEngine;

public class CarouselRotate11 : MonoBehaviour
{
    [SerializeField] private float _rotationTime = .2f;
    [SerializeField] private float _carouselSpeed = 40f;

    [SerializeField] private float _currentTime;
    [SerializeField] private float _maxExitTime = 10;
    [SerializeField] private bool _isExit;

    public Vector3 carouselRotateAngle;
    public Rigidbody carousel1;


    /*public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Rotate(_enterTime));
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (_isExit)
        {
            _currentTime = 0;
            _isExit = false;
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        StartCoroutine(RotateObject());
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!_isExit)
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > _maxExitTime)
            {
                StopCoroutine(RotateObject());
            }
        }
    }

    public IEnumerator RotateObject()
    {
        Rotate();
        yield return null;
    }

    private void Rotate()
    {
        Quaternion deltaRotation = Quaternion.Euler(carouselRotateAngle * Time.deltaTime);
        carousel1.MoveRotation(carousel1.rotation * deltaRotation);
    }
}
