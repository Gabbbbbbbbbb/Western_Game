using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestroy : MonoBehaviour
{
    public DialogueTrigHenryOne trigger;
    public float Interactions = 5;
    public GameObject Npc;

    public DialogueManageHenryOne Counting;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();
        }
    }

    public void Update()
    {
        if (Counting.NumberClickk >= Interactions)
        {
            Destroy(Npc);
        }
    }
}
