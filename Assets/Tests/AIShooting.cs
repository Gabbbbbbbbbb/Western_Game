using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooting : MonoBehaviour
{
    [SerializeField]
    private AIDetector detector;

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextShotTime;
    public Transform Fire;

    private void Awake()
    {
        detector = GetComponentInChildren<AIDetector>();
    }

    private void Update()
    {
        if (detector.TargetVisible && Time.time > nextShotTime)
        {
            Instantiate(projectile, Fire.position, Fire.rotation);
            nextShotTime = Time.time + timeBetweenShots;
        }
    }
}
