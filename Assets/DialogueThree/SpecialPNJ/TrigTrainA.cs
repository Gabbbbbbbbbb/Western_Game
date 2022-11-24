using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigTrainA : MonoBehaviour
{
    public Messagess[] messages;
    public Actorss[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<ManageTrainA>().OpenDialogue(messages, actors);
    }
}

[System.Serializable]
public class Messagess
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorss
{
    public string name;
    //public Sprite sprite;
}
