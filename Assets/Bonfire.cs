using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
  

  private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }
   /* {
        Debug.Log("hit detected");
        GameObject e = Instantiate(Explosion) as GameObject;
        e.transform.position = transform;
        Destroy(other.GameObject);
    }*/
}
