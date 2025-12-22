using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_Scene : MonoBehaviour
{
    public void Update()
    {
        if (ItemPickup.papeles_obt >= 7)
        {
            Invoke(nameof(CargarMenu), 35f);
            ItemPickup.papeles_obt = 0;
            Time.timeScale = 0f;
        }
    }

    void CargarMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
