using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    Rigidbody2D rgbd;
  
    private float limite = 1;
    public GameObject prjtl;
    private Animator anim;
    public GameObject player;
    public float velo;

    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("colidiu", false);

      
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if(transform.position.y >= limite)
        {
            Destroy(gameObject);
        }

        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Meteoro"))
        {
            
            FindObjectOfType<Player>().velBala = 0;
            rgbd.velocity = Vector2.zero;
            anim.SetBool("colidiu", true);
            Destroy(gameObject, 0.2f);
        }
    }


}
