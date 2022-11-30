using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject pressingEnter;
    public GameObject FirstSentence;
    public GameObject SecondSentence;
    public GameObject continueEnter;

    public int count = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            count += 1;
        }

        if(count == 1)
        {
            pressingEnter.SetActive(false);
            FirstSentence.SetActive(true);
            continueEnter.SetActive(true);
        }

        if (count == 2)
        {
            FirstSentence.SetActive(false);
            SecondSentence.SetActive(true);
        }

        if (count == 3)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
