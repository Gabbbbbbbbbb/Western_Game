using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;


    public GameObject bulletDownPrefab;
    public GameObject bulletPrefab;
    public GameObject bulletLeftPrefab;
    public GameObject bulletUpPrefab;

    public float fireRate = 0.3f;
    private float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }

        if (Input.GetButtonDown("Fire2") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot2();
        }

        if (Input.GetButtonDown("Fire3") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot3();
        }

        if (Input.GetButtonDown("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot4();
        }
    }

    void Shoot ()
    {
        //To spawn something, we use Instantiate
        Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
    }

    void Shoot2()
    {
        //To spawn something, we use Instantiate
        Instantiate(bulletLeftPrefab, firePoint3.position, firePoint3.rotation);
    }

    void Shoot3()
    {
        //To spawn something, we use Instantiate
        Instantiate(bulletUpPrefab, firePoint2.position, firePoint2.rotation);
    }

    void Shoot4()
    {
        //To spawn something, we use Instantiate
        Instantiate(bulletDownPrefab, firePoint.position, firePoint.rotation);
    }
}
