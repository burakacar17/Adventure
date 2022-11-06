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

    bool zemindeMi;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        HareketEt();
        Ziplama();
        
        
    }

    void HareketEt()
    {
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * hareketHizi, rb.velocity.y);       

    }

    void Ziplama()
    {
        if(zemindeMi && Input.GetButtonDown("Jump"))
        {
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
