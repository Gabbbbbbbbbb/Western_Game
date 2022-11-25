using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZswitchBlood : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;

    public GameObject enemy;
    public GameObject blood;

    public GameObject tpGates;
    public GameObject tpGatesNew;

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
        blood.SetActive(true);
        tpGates.SetActive(false);
        tpGatesNew.SetActive(true);
    }
}
