using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool init = false;

    public GameObject temoin;
    public GameObject writing;

    // Update is called once per frame
    void Update()
    {
        if(init == true)
        {
            temoin.SetActive(true);
            writing.SetActive(true);
        }

        if(init == false)
        {
            temoin.SetActive(false);
            writing.SetActive(false);
        }
    }

    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            init = true;
        }
    }

    public void OnTriggerExit2D(Collider2D colliderr)
    {
        if (colliderr.gameObject.CompareTag("Player") == true)
        {
            init = false;
        }
    }
}
