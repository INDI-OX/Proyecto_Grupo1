using UnityEngine;

public class ParedInvisible : MonoBehaviour
{
    public string TagBloqueado = "Movible";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(TagBloqueado))
            return;

        Physics2D.IgnoreCollision(
            collision.collider,
            GetComponent<Collider2D>()
        );
    }
}
