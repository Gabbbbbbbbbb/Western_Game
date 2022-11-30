using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Vector3 targetPosition;
    public float speed;
    public Rigidbody2D rb;
    public int damage = 20;

    // Start is called before the first frame update
    private void Start()
    {
        targetPosition = FindObjectOfType<PlayerController>().transform.position;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerController playerController = hitInfo.GetComponent<PlayerController>();
        playerController.TakeDamage(damage);
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position * 5, targetPosition * 5, speed * Time.deltaTime);

        Destroy(gameObject, 6);
    }
}
