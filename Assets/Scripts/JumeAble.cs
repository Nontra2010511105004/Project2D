using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        else if (collision.CompareTag("Spike"))
        {
            Debug.Log("dead");
            //Rigidbody2D rigidbody2D = gameObject.GetComponentInParent<Rigidbody2D>();
            //rigidbody2D.AddForce(new Vector2(0,jume), ForceMode2D.Impulse);
            SceneManager.LoadScene(0);
        }
    }
}
