using UnityEngine;

public class Oscuridad : MonoBehaviour
{
    public float reduccion = 1f;
    public Vector3 escala_final = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, escala_final, reduccion * Time.deltaTime);
    }
}
