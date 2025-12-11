using UnityEngine;

public class Move_player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;
    float i;
    public bool enPlataforma = false;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetInteger("Caminar", 0);
        if (Input.GetKeyDown(KeyCode.UpArrow) /* && enPlataforma == true */)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 4.5f);
            enPlataforma = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            i = -1;
            sp.flipX = true;
            animator.SetInteger("Caminar", 1);
        }
        else
        {
            i = 0; //Aca lo pongo en "0" porque si no el personaje cuando dejas de precionar conserva la inercia del movimiento previo.
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            i = 1;
            sp.flipX = false;
            animator.SetInteger("Caminar", 1);
        }
        rb.linearVelocity = new Vector2(i * 3f, rb.linearVelocity.y); //La varaible "i" la uso para determinar hacia que lado va y el "5" es la fuerza con al que lo hace.
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "plataforma")
        {
            enPlataforma = true; //Esto despues lo voy a actualizar para que no ocurra lo de que puda saltar de nuevo al tocar una plataforma desde cualquier lado.
        }
    }
}
