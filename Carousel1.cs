using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarouselRotate : MonoBehaviour
{

   
    public Rigidbody carousel1;
    public float speed = 40f;
    public float  degreesPerSecond = 60f;
    public float  degreesAmount = 270f;
    private float totalRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        // Quaternion start = Quaternion.identity;
        //  Quaternion end = Quaternion.Euler(150f, 150f, 90f);
           float currentAngle = carousel1.transform.rotation.eulerAngles.y;
          carousel1.transform.rotation =
          Quaternion.AngleAxis(currentAngle + (Time.deltaTime * degreesPerSecond), Vector3.up);
         totalRotation += Time.deltaTime * degreesPerSecond;
       // AngleY();
        //  Quaternion rot =
        // collision.rigidbody.MoveRotation()
        //  collision.rigidbody.transform.rotation.y = Quaternion.Lerp(start, end, Mathf.PingPong(Time.time, 1f)).y;
        //new Quaternion(collision.rigidbody.rotation.x, collision.rigidbody.rotation.y + Quaternion.Lerp(start, end, Mathf.PingPong(Time.time, 1f)), collision.rigidbody.rotation.z, collision.rigidbody.rotation.w);
        //.Rotate(0,1,0);
        //Quaternion.Lerp(start, end, Mathf.PingPong(Time.time, 1f));
        //new Quaternion(collision.rigidbody.rotation.x ,collision.rigidbody.rotation.y + Quaternion.Lerp(start, end, Mathf.PingPong(Time.time, 1f)), collision.rigidbody.rotation.z);

    }

    void FixedUpdate() 
    {
    }

    public void AngleY()
    {
        float currentAngle = transform.rotation.eulerAngles.y;
        carousel1.transform.rotation =
         Quaternion.AngleAxis(currentAngle + (Time.deltaTime * degreesPerSecond), Vector3.up);
      totalRotation += Time.deltaTime * degreesPerSecond;
    }


}
