using UnityEngine;

public class Oscuridad : MonoBehaviour
{
    public Vida vida;
    public float reduccion = 0.01f;
    public Vector3 escala_final = new Vector3(0.8489893f, 0.8489893f,0);
    public Vector3 escala_inicial;
    private int interaccion_1 = 0;
    private float timerDaño = 0f;
    public float intervaloDaño = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escala_inicial = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemPickup.interaccion > interaccion_1)
        {
            interaccion_1 = ItemPickup.interaccion;
            transform.localScale = escala_inicial;
        }
        if (Vector3.Distance(transform.localScale, escala_final) < 0.01f)
        {
            timerDaño += Time.deltaTime;

            if (timerDaño >= intervaloDaño)
            {
                vida.dañoEntrante(0.10f);
                timerDaño = 0f;
            }
        }
        else
        {
            timerDaño = 0f;
        }
        transform.localScale = Vector3.Lerp(transform.localScale, escala_final, reduccion * Time.deltaTime);
    }
}
