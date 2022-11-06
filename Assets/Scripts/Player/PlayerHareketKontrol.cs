using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareketKontrol : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    public float hareketHizi;
    public float ziplamaGucu;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * hareketHizi, rb.velocity.y);
    }
}
