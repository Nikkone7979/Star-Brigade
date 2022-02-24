using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile2 : MonoBehaviour
{


    public GameObject Projectile;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Shoot", 4.0f, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        



    }

    void Shoot()
    {
        Instantiate(Projectile, firePoint.position, firePoint.rotation);



    }
}
