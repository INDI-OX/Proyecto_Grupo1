using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject panelPausa;
    private bool enPausa = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        
            enPausa = !enPausa;
            if (enPausa == true)
            {
                panelPausa.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                panelPausa.SetActive(false);
                Time.timeScale = 1.0f;
            }
    }
}
