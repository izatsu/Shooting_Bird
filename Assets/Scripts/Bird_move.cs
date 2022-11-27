using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private float time;
    public float speed = 5f;
    private Vector2 move;

    float a, b, c;
   



    private void Start()
    {
        c = transform.position.x;
    }


    private void Update()
    {
        
        time -= Time.deltaTime;
        if(time <= 0)
        {   
            a = Random.Range(-1f, 1f);
            b = Random.Range(-1f, 1f);
            c = transform.position.x;
            move = new Vector2(a,b);
            time = Random.Range(2f, 4f);
        }

        if (transform.position.x > c)
            c = transform.position.x;

      

        if (c > transform.position.x)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

        }

    }

    private void FixedUpdate()
    {      
        rb.AddForce(move * speed);
        
    }

        

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Limit"))
        {
            move = -move;
            Debug.Log("Da doi vi tri");
        }    
    }
}
