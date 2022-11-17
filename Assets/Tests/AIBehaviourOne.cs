using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviourOne : MonoBehaviour
{

    [SerializeField]
    private AIDetector detector;


    public float speed;
    public float distance;
    public Transform player;
    public float distanceBetween;

    private void Awake()
    {
        detector = GetComponentInChildren<AIDetector>();
    }

    private void Update()
    {

        if (detector.TargetVisible)
        {
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

            transform.rotation = Quaternion.Euler(Vector3.forward * angle);

            if (distance < distanceBetween)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            }
        }
    }
}
