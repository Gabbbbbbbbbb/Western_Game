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

    public void Death()
    {
        if (checkingin = true && Player.health <= 0)
        {
            NoHealth = true;
            PlayerCharacter.position = RespawnPoint.position;
            Player.health = 100;
        }
    }
}
