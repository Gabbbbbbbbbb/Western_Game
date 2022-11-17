using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLeft : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    public int damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        // TIP 2D shooting in Unity, 8:48 approximately. He's saying something about "axis" and all
        rb.velocity = Vector3.left * speed;
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
    }

    void Update()
    {
        Destroy(gameObject, 3);
    }
}
