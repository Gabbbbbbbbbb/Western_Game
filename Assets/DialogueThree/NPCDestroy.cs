using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestroy : MonoBehaviour
{
    public DialogueTrigger trigger;
    public float Interactions = 5;
    public GameObject Npc;

    public DialogueManagerr Counting;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();
        }
    }

    public void Update()
    {
        if (Counting.NumberClick >= Interactions)
        {
            Destroy(Npc);
        }
    }
}
