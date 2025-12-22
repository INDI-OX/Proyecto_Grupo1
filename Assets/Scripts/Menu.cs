using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject menu;
    public GameObject menu_Instrucciones;
    public GameObject menu_Creditos;
    public AudioClip boton_Sonido;
    AudioSource audioSource;
    public void Salir()
    {
        Application.Quit();
    }

    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
        if (boton_Sonido != null)
        {
            audioSource.PlayOneShot(boton_Sonido);
        }
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
        if (boton_Sonido != null)
        {
            audioSource.PlayOneShot(boton_Sonido);
        }
    }

    public void Instrucciones()
    {
        menu.SetActive(false);
        menu_Instrucciones.SetActive(true);
        if (boton_Sonido != null)
        {
            audioSource.PlayOneShot(boton_Sonido);
        }
    }
    public void Creditos()
    {
        menu.SetActive(false);
        menu_Creditos.SetActive(true);
        if (boton_Sonido != null)
        {
            audioSource.PlayOneShot(boton_Sonido);
        }
    }
    public void Atras()
    {
        menu_Instrucciones.SetActive(false);
        menu.SetActive(true);
        if (boton_Sonido != null)
        {
            audioSource.PlayOneShot(boton_Sonido);
        }
    }
    public void AtrasCreditos()
    {
        menu_Creditos.SetActive(false);
        menu.SetActive(true);
        if (boton_Sonido != null)
        {
            audioSource.PlayOneShot(boton_Sonido);
        }
    }
}
