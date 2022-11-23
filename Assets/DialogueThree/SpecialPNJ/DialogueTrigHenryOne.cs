using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigHenryOne : MonoBehaviour
{
    public Messagee[] messages;
    public Actorr[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManageHenryOne>().OpenDialogue(messages, actors);
    }
}

[System.Serializable]
public class Messagee
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorr
{
    public string name;
    //public Sprite sprite;
}
