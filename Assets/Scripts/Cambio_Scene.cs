using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_Scene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Update()
    {
        if (ItemPickup.papeles_obt >= 7)
        {
            Invoke(nameof(CargarMenu), 18f);
        }
    }

    void CargarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
