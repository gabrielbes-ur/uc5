using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rgbd;
    float move;
    public int vidas = 3;
    public int score = 0;
    public GameObject projetil;
    public GameObject jogador;
    public Transform tiro;
    public float velBala;

    

    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        tiro = jogador.transform.GetChild(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal") * speed;
        rgbd.velocity = new Vector2(move, rgbd.velocity.y);

       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Tiro();
        }

        if(vidas <= 0)
        {
            Destroy(gameObject);
            Derrota();
        }

        if(score >= 30)
        {
            Vitoria();
        }
    }

    

    public void Tiro()
    {
        velBala = 200f;
        GameObject bala = Instantiate(projetil, tiro.transform.position, projetil.transform.rotation);
        bala.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, velBala));
        Destroy(bala.gameObject, 3f);
    }

    public void Vitoria()
    {
        
      SceneManager.LoadScene("Vitoria");
        
    }

    public void Derrota()
    {
        SceneManager.LoadScene("Derrota");
    }

  












}
 