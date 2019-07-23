using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float Speed = 4f;
    Animator Animador;
    Rigidbody2D RB2D;
    Vector2 Movimiento;

    //public GameObject Proyectil;
    


    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Animador = GetComponent<Animator>();
        RB2D = GetComponent<Rigidbody2D>();
       

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento = new Vector2(
           Input.GetAxisRaw("Horizontal"),
           Input.GetAxisRaw("Vertical")
           );
        
        if(Movimiento != Vector2.zero)
        {
            Animador.SetFloat("MovX", Movimiento.x);
            Animador.SetFloat("MovY", Movimiento.y);
            Animador.SetBool("Walking", true);
        }
        else
        {
            Animador.SetBool("Walking", false);
        }
      
    }
    void FixedUpdate()
    {
        RB2D.MovePosition(RB2D.position + Movimiento * Speed * Time.deltaTime);
    }

   
   
   
   
}
