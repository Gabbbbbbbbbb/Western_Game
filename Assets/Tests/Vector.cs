using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public GameObject goal;
    Vector3 direction;
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //pour faire un d�placement depuis le pt de d�part du monde (pour essayer d'atteindre un objet) :
        //this.transform.Translate(goal.transform.position);

        //Pour faire un d�placement depuis pt de d�part de l'objet :
        //this.transform.Translate(6, 7, 0);


        //Pour "jump" au "goal" peu importe le lieu : (La premi�re ligne est le calcul et la seconde est l'utilisation de ce calcul. goal position - pig position)
        //direction = goal.transform.position - this.transform.position;
        //this.transform.position = this.transform.position + direction;
        // Ligne du dessus �quivaut � : this.transform.Transalte(direction);

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //L'objet ne va pas s'arr�ter. Et la vitesse va �tre tr�s �trange et pas similaire pour chaque objet.
        //this.transform.position = this.transform.position + direction * 0.001f;

        //direction est le vector des pig jusqu'au goal
        direction = goal.transform.position - this.transform.position;


        //Permet de faire en sorte que l'objet face face � ce qu'il suit (semble bien marcher en 3d mais pas en 2d) : 
        //this.transform.LookAt(goal.transform.position);

        //Le chiffre indique un cercle autour duquel l'objet s'arr�tera.
        if(direction.magnitude > 4)
        {
            //Version avec vitesse stable et similaire pour tous les objets qui se d�placent : (ne pas oublier le float speed et le vector 3 direction) (marche avec la premi�re ligne du dernier code de start)
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            //this.transform.position = this.transform.position + direction.normalized;
            this.transform.position = this.transform.position + velocity;
        }

        

    }
}
