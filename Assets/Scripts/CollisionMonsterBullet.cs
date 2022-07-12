using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll) {

        if(coll.gameObject.tag == "Monster" || coll.gameObject.tag == "Bullet"){

            Physics2D.IgnoreCollision(coll.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        }else{

            Destroy(gameObject);
            if(coll.gameObject.tag != "Wall"){

                Destroy(coll.gameObject);
            }
        }
        
    }
}
