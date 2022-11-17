using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public float speed = 3f;
    Vector3 targetPosition;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
       //targetPosition = FindObjectOfType<PlayerController>().transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.RotateTowards();
        Vector3 targetDirection = target.position - transform.position;
        float singleStep = speed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
