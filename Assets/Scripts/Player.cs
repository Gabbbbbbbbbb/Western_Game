using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fuel;
    bool autopilot = false;
    float speed = 2f;
    float rspeed = 0.5f;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;


    void AutoPilot()
    {
        CalculateAngle();
        this.transform.position += this.transform.up * speed * Time.deltaTime;
    }

    void CalculateAngle()
    {
        Vector3 tankForward = transform.up;
        Vector3 fuelDirection = fuel.transform.position - transform.position;

        Debug.DrawRay(this.transform.position, tankForward * 10, Color.green, 6);
        Debug.DrawRay(this.transform.position, fuelDirection, Color.red, 6);

        float dot = tankForward.x * fuelDirection.x + tankForward.y * fuelDirection.y;
        float angle = Mathf.Acos(dot / (tankForward.magnitude * fuelDirection.magnitude));

        Debug.Log("Angle : " + angle * Mathf.Rad2Deg);
        Debug.Log("Unity Angle : " + Vector3.Angle(tankForward, fuelDirection));

        int clockwise = 1;
        if (Cross(tankForward, fuelDirection).z < 0)
            clockwise = -1;

        //Ca permet de tourner vers la cible en ayant calculé l'angle.
        if ((angle * Mathf.Rad2Deg) > 10)
            this.transform.Rotate(0, 0, angle * Mathf.Rad2Deg * clockwise * rspeed);
    }


    Vector3 Cross(Vector3 v, Vector3 w)
    {
        float xMult = v.y * w.z - v.z * w.y;
        float yMult = v.x * w.z - v.z * w.x;
        float zMult = v.x * w.y - v.y * w.x;

        return (new Vector3(xMult, yMult, zMult));
    }


    float CalculateDistance()
    {
        float distance = Mathf.Sqrt(Mathf.Pow(fuel.transform.position.x - transform.position.x,2) + Mathf.Pow(fuel.transform.position.y - transform.position.y,2));

        Vector3 fuelPos = new Vector3(fuel.transform.position.x, 0, fuel.transform.position.y);
        Vector3 tankPos = new Vector3(transform.position.x, 0, transform.position.y);
        float uDistance = Vector3.Distance(fuelPos, tankPos);

        Vector3 tankToFuel = fuelPos - tankPos;
        
        //Debug.Log("Distance : " + distance);
        //Debug.Log("U Distance : " + uDistance);
        //Debug.Log("V Magnitude : " + tankToFuel.magnitude);

        //last one is the method that uses not that much processing for the machine : 
        //Debug.Log("V SqMagnitude : " + tankToFuel.sqrMagnitude);

        return distance;

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    void LateUpdate()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CalculateDistance();
            CalculateAngle();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            autopilot = !autopilot;
        }

        if (CalculateDistance() < 2)
            autopilot = false;

        if (autopilot)
            AutoPilot();
    }
}
