using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float vidaMaxima = 1f;
    public float vidaActual;
    public Canvas barraCompleta;
    public Image barraVida;
    private bool barraVisible = false;
    public float temporizador;
    private float tiempoVisible = 1f;
    void Start()
    {
        vidaActual = vidaMaxima;
        actualizarBarra();
        barraCompleta.enabled = false;
}
    public void dañoEntrante(float daño)
    {
        vidaActual -= daño;
        if (vidaActual < 0)
        {
            vidaActual = 0;
        }
        actualizarBarra();
        
        barraCompleta.enabled = true;
        barraVisible = true;
        temporizador = tiempoVisible;

        if (vidaActual == 0)
        {
            muerte();
        }

    }
    void muerte()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Menu");
    }

    void actualizarBarra()
    {
        barraVida.fillAmount = vidaActual/vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        if (!barraVisible)return;
        temporizador -= Time.deltaTime;

        if (temporizador <= 0)
        {
            barraCompleta.enabled=false;
            barraVisible=false;
        }
    }
}
