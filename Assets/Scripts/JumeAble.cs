using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumeAble : MonoBehaviour
{
    public float jume = 5.0f; 
    void Start()
    {
        //Debug.Log("JumeAble's attached");
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Platform"))       
        {
            //Debug.Log("im collided");
            Rigidbody2D rigidbody2D = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody2D.AddForce(new Vector2(0,jume), ForceMode2D.Impulse);
        }
    }
}
