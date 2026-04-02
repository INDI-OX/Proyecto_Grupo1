using UnityEngine;

public class Move_player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;
    float i;
    public bool enPlataforma = false;
    private Animator animator;
    public float distancia_Plataforma = 0.15f;
    public Transform posicion_Pies;
    public Transform posicion_Pies_1;
    public LayerMask piso;
    public AudioClip sonido_Salto;
    AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        SobrePlataforma();
        animator.SetInteger("Move", 0);
        if (Input.GetKeyDown(KeyCode.UpArrow) && enPlataforma == true )
        {
            animator.SetInteger("Move", 2);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 4.5f);
            if (sonido_Salto != null)
            {
                audioSource.PlayOneShot(sonido_Salto);
            }
            enPlataforma = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            i = -1;
            sp.flipX = true;
            animator.SetInteger("Move", 1);
        }
        else
        {
            i = 0; //Aca lo pongo en "0" porque si no el personaje cuando dejas de precionar conserva la inercia del movimiento previo.
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            i = 1;
            sp.flipX = false;
            animator.SetInteger("Move", 1);
        }
        rb.linearVelocity = new Vector2(i * 3f, rb.linearVelocity.y); //La varaible "i" la uso para determinar hacia que lado va y el "5" es la fuerza con al que lo hace.
    }
    void SobrePlataforma()
    {
        RaycastHit2D hit = Physics2D.Raycast(posicion_Pies.position, Vector2.down,distancia_Plataforma,piso);
        RaycastHit2D hit1 = Physics2D.Raycast(posicion_Pies_1.position, Vector2.down, distancia_Plataforma, piso);
        enPlataforma = hit.collider != null|| hit1.collider != null;
        Debug.DrawRay(posicion_Pies.position, Vector2.down * distancia_Plataforma, Color.red);
    }
}
