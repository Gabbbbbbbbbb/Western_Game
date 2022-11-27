using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigSwann : MonoBehaviour
{
    public Messagesss[] messages;
    public Actorsss[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<ManageSwann>().OpenDialogue(messages, actors);
    }
}

[System.Serializable]
public class Messagesss
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorsss
{
    public string name;
    //public Sprite sprite;
}
