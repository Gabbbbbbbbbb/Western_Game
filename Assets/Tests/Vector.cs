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
        //pour faire un déplacement depuis le pt de départ du monde (pour essayer d'atteindre un objet) :
        //this.transform.Translate(goal.transform.position);

        //Pour faire un déplacement depuis pt de départ de l'objet :
        //this.transform.Translate(6, 7, 0);


        //Pour "jump" au "goal" peu importe le lieu : (La première ligne est le calcul et la seconde est l'utilisation de ce calcul. goal position - pig position)
        //direction = goal.transform.position - this.transform.position;
        //this.transform.position = this.transform.position + direction;
        // Ligne du dessus équivaut à : this.transform.Transalte(direction);

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //L'objet ne va pas s'arrêter. Et la vitesse va être très étrange et pas similaire pour chaque objet.
        //this.transform.position = this.transform.position + direction * 0.001f;

        //direction est le vector des pig jusqu'au goal
        direction = goal.transform.position - this.transform.position;


        //Permet de faire en sorte que l'objet face face à ce qu'il suit (semble bien marcher en 3d mais pas en 2d) : 
        //this.transform.LookAt(goal.transform.position);

        //Le chiffre indique un cercle autour duquel l'objet s'arrêtera.
        if(direction.magnitude > 4)
        {
            //Version avec vitesse stable et similaire pour tous les objets qui se déplacent : (ne pas oublier le float speed et le vector 3 direction) (marche avec la première ligne du dernier code de start)
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            //this.transform.position = this.transform.position + direction.normalized;
            this.transform.position = this.transform.position + velocity;
        }

        

    }
}
