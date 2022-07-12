using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterController : MonoBehaviour
{   
    public GameObject monster1, monster2;

    public float interVal = 3f;
    public float startInterVal = 1f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnMonster), startInterVal, interVal);
    }

    void SpawnMonster(){

        float randomVal = Random.value;

        if (randomVal < 0.2){

            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);

        }else if(randomVal < 0.4){

            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);

        }else{

        }
    }

    
}
