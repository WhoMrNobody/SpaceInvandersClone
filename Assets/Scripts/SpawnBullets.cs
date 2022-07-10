using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{
    public GameObject bullet;
    public float interVal = 1.0f;
    
    void Start()
    {
        InvokeRepeating("SpawnBullet", interVal, interVal);
    }

   
    void Update()
    {
        
    }

    void SpawnBullet(){

        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
