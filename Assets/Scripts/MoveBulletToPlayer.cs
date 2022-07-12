using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBulletToPlayer : MonoBehaviour
{
    public float speed= 1f;

    Rigidbody2D _rb;

    void Awake() {

        _rb=GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
        //Vector3 vec3 = (gameObject.transform.position - transform.position).normalized;
        //Vector2 vec2 = new Vector2(vec3.x, vec3.y);
        if(gameObject != null){
            Vector2 playerPos = (gameObject.transform.position - transform.position).normalized;
            _rb.velocity = playerPos * speed;
        }
        
    }

    
}
