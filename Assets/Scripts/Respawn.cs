using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public PlayerController Player;
    public Transform PlayerCharacter;
    public Transform RespawnPoint;

    public bool checkingin = false;

    /*public void MarcheStp()
    {
        OnTriggerStay2D(Collider2D collider);
    }*/


    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            checkingin = true;
            if (Player.health <= 0)
            {
                PlayerCharacter.position = RespawnPoint.position;
            }
        }
    }
}
