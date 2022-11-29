using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareketKontrol : MonoBehaviour
{
    
    Rigidbody2D rb;

    [SerializeField]
    float hareketHizi;

    [SerializeField]
    float ziplamaGucu;

    Animator animator;

    public bool zemindeMi;
    public bool doubleJump;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        HareketEt();
        Ziplama();
        animator.SetBool("zemindeMi", zemindeMi);




    }

    void HareketEt()
    {
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * hareketHizi, rb.velocity.y);
        animator.SetFloat("hareketHizi", Mathf.Abs(rb.velocity.x));


    }

    void Ziplama()
    {
        if((zemindeMi || doubleJump) && Input.GetButtonDown("Jump"))
        {
            if (zemindeMi)
            {
                doubleJump = true;
            }
            else
            {
                doubleJump = false;
            }

            rb.velocity = new Vector2(rb.velocity.x, ziplamaGucu);
            zemindeMi = false;

            



        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Zemin"))
        {
            zemindeMi = true;
            

        }
    }




}
