using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIChase : MonoBehaviour
{

   /* public GameObject player;
    public float speed;

    public float distanceBetween;

    private float distance;*/



    public float speed;
    public Transform target;
    public float minimumDistance;

    public Transform Fire;
    public GameObject projectile;
    public float timeBetweenShots;
    private float nextShotTime;


    public float distance;
    public Transform player;
    public float distanceBetween;

    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        //pas nécessaire(utile pour top down view mais pas bird's eye view)(à mettre dans le if en bas si jamais) : 
         transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        }
    }



    /*void Update()
    {
        //this.transform.position.z = target.transform.position;
        *//*Vector3 targetDirection = target.position - transform.position;
        float singleStep = speed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);*/


        /*targetPosition = GameObject.FindGameObjectWithTag("PlayerCharacter");

        Vector3 rotation = targetPosition - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);*//*

        if (Time.time > nextShotTime)
        {
            Instantiate(projectile, Fire.position, Fire.rotation);
            nextShotTime = Time.time + timeBetweenShots;
        }

        if (Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
        

    }*/
}

/*public class OnTrigger2DUtil : MonoBehaviour
{
    public string targetTag = "PlayerCharacter";
    public UnityEvent OnTriggerEnterEvent, OnTriggerExitEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            OnTriggerEnterEvent?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            OnTriggerExitEvent?.Invoke();
        }
    }
}*/