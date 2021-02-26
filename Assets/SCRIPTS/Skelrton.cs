using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelrton : MonoBehaviour
{
    public float speed=-10;
  
   


    // Update is called once per frame
    public void Update()
    {
        //make skelrton move left
          transform.Translate(2 * Time.deltaTime * speed,0, 0);
            transform.localScale = new Vector2(4.4159f, 4.4159f);
    }
    private bool isGrounded()
    {
        return transform.Find("GroundCheck").GetComponent<GroundCheck>().isGrounded;
    }



}