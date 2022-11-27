using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSwann : MonoBehaviour
{
    public TrigSwann trigger;
    public float Interactions = 5;
    public GameObject Npc;

    public ManageSwann Counting;

    public GameObject Door;

    private bool canDestroy = true;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();

        }
    }

    public void Update()
    {
        if (Counting.NumberClickk >= Interactions && canDestroy == true)
        {
            //Instantiate(NpcPrefab, Switching.position, Switching.rotation);
            Door.SetActive(true);
            Destroy(Npc);
            canDestroy = false;
        }
    }
}
