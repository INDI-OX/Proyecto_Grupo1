using System.Collections.Generic;
using UnityEngine;

public class Seccionado : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> plataformaA;
    public List<GameObject> plataformaB;
    public bool activar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //Aca esta el tag de "Player" que lo tiene por defecto el Unity, despues vemos si lo cambiamos.
        {
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Este Script debe ser agregado a todos los recuadros de interaccion que tengan que ver con el cambio de seccion, IMPORTANTE: Tiene que tener la propiedad OnTrigger en la colicion.
}
