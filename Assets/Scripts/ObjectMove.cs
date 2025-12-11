using UnityEngine;

public class MoveBetweenPoints : MonoBehaviour
{
    [Header("Puntos a modificar desde el inspector")]
    public Vector3 pointA;
    public Vector3 pointB;

    [Header("Movimiento")]
    public float speed = 2f;

    private Vector3 target;

    void Start()
    {
        // Empezamos moviendo hacia B
        target = pointB;
    }

    void Update()
    {
        // Movimiento independiente de la rotación
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Si llegó al destino → cambiar objetivo
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointA) ? pointB : pointA;
        }
    }
}
