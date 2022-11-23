using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public PlayerController Player;
    public Transform PlayerCharacter;
    public Transform RespawnPoint;

    public bool checkingin = false;
    public bool NoHealth = false;

    /*public void MarcheStp()
    {
        OnTriggerStay2D(Collider2D collider);
    }*/


    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            checkingin = true;
            /*if (checkingin == true)
            {
                Death();
            }*/
        }
    }

    public void OnTriggerExit2D(Collider2D colliderr)
    {
        if (colliderr.gameObject.CompareTag("Player") == true)
        {
            checkingin = false;
        }
    }

    void Update()
    {
        if (Player.health <= 0)
        {
            NoHealth = true;
        }

        if (checkingin = true && Player.health <= 0)
        {
            NoHealth = true;
            PlayerCharacter.position = new Vector2 (RespawnPoint.position.x, RespawnPoint.position.y);
            Player.Die();
        }
    }
}
