using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCbarmanG : MonoBehaviour
{
    public TrigBarmanG trigger;
    public float Interactions = 5;
    public GameObject Npc;

    public ManageBarmanG Counting;

    public GameObject NpcPrefab;
    public Transform Switching;

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
        if(Counting.NumberClickk >= Interactions && canDestroy == true)
        {
            Instantiate(NpcPrefab, Switching.position, Switching.rotation);
            Destroy(Npc);
            canDestroy = false;
        }
    }
}
