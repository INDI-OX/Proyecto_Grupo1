using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int vidaJ = 100;
    public int vida;
    float tiempoEx = 1f;
    public Slider barraVida; //Esto es un componente que agregas en Unity, lo encontras en la seccion de Canvas como "Slider".
    public Canvas visibleBarra; //En esta parte agragas directamente el canvas de donde esta puesto el "Slider".
    void Start()
    {
        vida = vidaJ;
        actualizarBarra();
        visibleBarra.enabled = false;
    }
    public void dañoEntrante(int daño)
    {
        vida -= daño;
        if (vida < 0)
        {
            vida = 0;
        }

        actualizarBarra();
        visibleBarra.enabled = true; //Hago que la barrera sea visible hasta que pase el tiempo que impuse abajo.

        if (vida == 0)
        {
            muerte();
        }

    }
    void muerte()
    {
        Destroy(gameObject);
    }

    void actualizarBarra()
    {
        if (barraVida != null)
        {
            barraVida.value = (float)vida / vidaJ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (visibleBarra.enabled == true)
        {
            tiempoEx -= Time.deltaTime;
            if (tiempoEx <= 0)
            {
                visibleBarra.enabled = false;
                tiempoEx = 1; //Esta es la variable que controla el tiempo que la variable aparece en pantalla antes de desaparecer.
            }
        }
    }
    //Este Script debe ser agregado al jugador.
}
