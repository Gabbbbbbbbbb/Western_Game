using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigBarmanG : MonoBehaviour
{
    public Messages[] messages;
    public Actors[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<ManageBarmanG>().OpenDialogue(messages, actors);
    }
}

[System.Serializable]
public class Messages
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actors
{
    public string name;
    //public Sprite sprite;
}
