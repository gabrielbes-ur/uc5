using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour
{
    Rigidbody2D rgbd;
    private float speed = 300;
    public int dano = 1;
    private float limite = -4;
    public GameObject meteoro;
    public Animator anim;
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        rgbd.velocity = new Vector2(rgbd.velocity.x, -speed * Time.deltaTime);

        if(transform.position.y <= limite)
        {
            Destroy(meteoro);
        }

        Destroy(gameObject, 3f);
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {

            speed = 0;
            anim.SetTrigger("colide");
            FindObjectOfType<Player>().score += 1;

            Destroy(gameObject, 1);
               
                
            
        }

        if (collision.CompareTag("Jogador"))
        {
            speed = 0;
            anim.SetTrigger("colide");
            FindObjectOfType<Player>().vidas -= dano;

            Destroy(gameObject, 1);
        }
    }
}

