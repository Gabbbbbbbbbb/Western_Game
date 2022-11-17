using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public DialogueTrigger trigger;
    public float Interactions = 5;
    public GameObject Npc;

    public DialogueManagerr Counting;

    public GameObject NpcPrefab;
    public Transform Switching;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();
        }
    }

    public void Update()
    {
        if(Counting.NumberClick >= Interactions)
        {
            Instantiate(NpcPrefab, Switching.position, Switching.rotation);
            Destroy(Npc);
            
        }
    }
}
