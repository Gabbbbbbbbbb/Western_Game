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
        //Damages done by a CAC enemy.
        if (collider.gameObject.CompareTag("Player") == true)
        {
            Character.TakeDamage(damage);
        }
    }
}
