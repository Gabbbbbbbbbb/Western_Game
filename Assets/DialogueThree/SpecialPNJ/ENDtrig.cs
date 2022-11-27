using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDtrig : MonoBehaviour
{
    public Messagessss[] messages;
    public Actorssss[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<ENDmanage>().OpenDialogue(messages, actors);
    }
}

[System.Serializable]
public class Messagessss
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorssss
{
    public string name;
    //public Sprite sprite;
}
