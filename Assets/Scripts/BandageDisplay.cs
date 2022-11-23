using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BandageDisplay : MonoBehaviour
{
    int Value = 0;

    public Text ValueText;

    public PlayerController playerb;

    void Start()
    {
        //ValueText.text = Value.ToString();
    }

    void Update()
    {
        Value = playerb.bandage;
        ValueText.text = Value.ToString();
    }
}
