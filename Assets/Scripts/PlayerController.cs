using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    public int health = 100;

    public HealthBar healthBar;
    public int currentHealth;

    public int bandage = 3;
    public int healingb = 20;

    public Respawn respawn;

    /*public bool isTalking;*/

    void Start()
    {
        currentHealth = health;
        healthBar.SetMaxHealth(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        currentHealth -= damage;
        if (health <= 0)
        {
            /*            respawn.OnTriggerStay2D();
            */            //Die();
            //health = 100;
            bandage = 2;
            currentHealth = 100;
        }
        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Destroy(gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        /*if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }*/

        /*if (DialogueManagerr.isActive == true)
        {

        }*/
            

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("space") && bandage > 0 && health < 100)
        {
            health += healingb;
            currentHealth += healingb;
            healthBar.SetHealth(currentHealth);
            bandage -= 1;

            
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PickUpHeal") == true)
        {
            bandage += 1;
        }

    }

    /*void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {

        }
    }*/
}
