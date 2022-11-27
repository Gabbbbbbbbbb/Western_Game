using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZSwitchSwann : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;

    public GameObject enemy;
    public GameObject deadSwann;
    public Transform Swann;
    public Transform dedSwann;


    void Update()
    {
        dedSwann.position = Swann.position;
    }

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Destroy(gameObject);
        enemy.SetActive(false);
        deadSwann.SetActive(true);
    }
}
