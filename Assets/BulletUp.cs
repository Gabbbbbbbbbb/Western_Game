using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUp : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    public int damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        // TIP 2D shooting in Unity, 8:48 approximately. He's saying something about "axis" and all
        rb.velocity = Vector3.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // TIP Comment user d'une partie de script présente dans un autre script : créer un public void et GetComponent<SCRIPT>()
        Ennemy ennemy = hitInfo.GetComponent<Ennemy>();
        if (ennemy != null)
        {
            ennemy.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);

        ZswitchBlood switchblood = hitInfo.GetComponent<ZswitchBlood>();
        if (switchblood != null)
        {
            switchblood.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);


        ZSwitchSwann switchswann = hitInfo.GetComponent<ZSwitchSwann>();
        if (switchswann != null)
        {
            switchswann.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
    }

    void Update()
    {
        Destroy(gameObject, 1);
    }
}
