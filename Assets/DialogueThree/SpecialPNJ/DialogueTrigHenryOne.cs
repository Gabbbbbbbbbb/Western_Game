using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigHenryOne : MonoBehaviour
{
    public Messagee[] messagess;
    public Actorr[] actorss;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManageHenryOne>().OpenDialogue(messagess, actorss);
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
