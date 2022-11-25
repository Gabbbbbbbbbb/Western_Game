using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrainA : MonoBehaviour
{
    public TrigTrainA trigger;
    public float Interactions = 5;
    public GameObject Npc;

    public ManageTrainA Counting;

    //public Transform Switching;

    public GameObject NpcPrefab; //Remplacer pnj par un autre pnj normal
    public GameObject Carriage; //Spawn de l'intéraction sur R4.

    public GameObject bandits; //Bandits à supprimer sur R4.


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
            //Faire spawn plus de prefab
            //Instantiate(NpcPrefab, Switching.position, Switching.rotation);
            NpcPrefab.SetActive(true);
            Carriage.SetActive(true);
            Destroy(Npc);
            Destroy(bandits);

            canDestroy = false;
        }
    }
}
