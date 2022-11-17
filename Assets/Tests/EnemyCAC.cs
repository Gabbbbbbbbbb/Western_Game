using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCAC : MonoBehaviour
{
    public int damage = 10;

    public Rigidbody2D rb;

    public PlayerController Character;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        /*PlayerController playerController = GetComponent<PlayerController>();
        playerController.TakeDamage(damage);*/
        if (collider.gameObject.CompareTag("Player") == true)
        {
            Character.TakeDamage(damage);
        }
    }
}
