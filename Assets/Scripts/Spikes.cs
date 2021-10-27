using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public float jume = 5.0f; 
    void Start()
    {
        //Debug.Log("dead");
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Spike"))
        {
            Debug.Log("dead");
            Rigidbody2D rigidbody2D = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody2D.AddForce(new Vector2(0,jume), ForceMode2D.Impulse);
            
        }
     

    }
    void Update()
    {
    
    }

}
