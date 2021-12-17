using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform projectilespawn;
    public GameObject bullet;
    public float firerate = 1.0f;
    public float thistime = 0.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        projectilespawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        thistime += Time.deltaTime;
        if(Input.GetButton("Fire1")&& thistime > firerate)
        {
            firerate += thistime;
            Instantiate(bullet, projectilespawn.position, Quaternion.identity);
            firerate -= thistime;
            thistime = 0.0f;
        }
    }
}
