using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject menu;

    public void Salir()
    {
        Application.Quit();
    }

    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
