using System.Collections.Generic;
using UnityEngine;

public class Seccionado : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> plataformaA;
    public List<GameObject> plataformaB;
    public Vector2 spawnPosition;
    public bool activar;
    public AudioClip puerta;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (puerta != null)
        {
            audioSource.PlayOneShot(puerta);
        }
        if (collision.CompareTag("Player"))
        {
            // Cambia plataformas
            if (activar)
            {
                ActivarLista(plataformaA, false);
                ActivarLista(plataformaB, true);
            }
            else
            {
                ActivarLista(plataformaA, true);
                ActivarLista(plataformaB, false);
            }

            collision.transform.position = spawnPosition;
        }
    }

    void ActivarLista(List<GameObject> lista, bool activacion)
    {
        foreach (GameObject obj in lista)
        {
            if (obj != null)
            {
                obj.SetActive(activacion); //Aca recorre y aplica este codigo a todos los objetos dentro del array.
            }
        }
    }
    //Este Script debe ser agregado a todos los recuadros de interaccion que tengan que ver con el cambio de seccion, IMPORTANTE: Tiene que tener la propiedad OnTrigger en la colicion.
}
