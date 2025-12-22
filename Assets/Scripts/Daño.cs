using UnityEngine;

public class Daño : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float daño = 0.10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Vida vida = collision.collider.GetComponent<Vida>(); //Llamo a el Script de vida para determinar el daño entrante.
            if (vida != null)
            {
                vida.dañoEntrante(daño);
            }
        }
    }
    //Este Script debe ser aplicado a el objeto o enemigo que genere daño pasivo al tocarlo.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
