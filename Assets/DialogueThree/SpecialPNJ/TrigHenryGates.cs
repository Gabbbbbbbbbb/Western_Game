using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigHenryGates : MonoBehaviour
{
    public Messageee[] messagesss;
    public Actorrr[] actorsss;

    public void StartDialogue()
    {
        FindObjectOfType<ManageHenryGates>().OpenDialogue(messagesss, actorsss);
    }
}

[System.Serializable]
public class Messageee
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorrr
{
    public string name;
    //public Sprite sprite;
}
