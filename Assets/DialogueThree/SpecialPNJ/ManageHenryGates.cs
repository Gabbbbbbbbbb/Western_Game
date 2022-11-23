using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageHenryGates : MonoBehaviour
{
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;

    Messageee[] currentMessages;
    Actorrr[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;

    //public NPC npcScript;

    public float NumberClickk = 0;

    public void OpenDialogue(Messageee[] messagesss, Actorrr[] actorsss)
    {
        currentMessages = messagesss;
        currentActors = actorsss;
        activeMessage = 0;
        isActive = true;

        Debug.Log("Started conversation ! Loaded messages :" + messagesss.Length);
        DisplayMessage();

        backgroundBox.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
    }

    void DisplayMessage()
    {
        Messageee messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actorrr actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;

        AnimateTextColor();
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("Conversation ended !");
            isActive = false;
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
        }
    }

    void AnimateTextColor()
    {
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            NextMessage();
            NumberClickk += 1;
            //npcScript.SelfPlusOne();

            //SelfDestruct += 1;
            //NPc.GetComponent<NPC>().SelfDestruct += 1;
            /*NPC Npc = GetComponent<NPC>();
            Npc.SelfPlusOne();*/

            /*NPC gotit = gameObject.GetComponent<NPC>();
            //NPC.SelfPlusOne();
            NPC.SelfDestruct += 1;*/
        }

        /*if (SelfDestruct == 5)
        {
            trigger.Death();
        }*/
    }
}
