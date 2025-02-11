using UnityEngine;

public class KeyAnimation : MonoBehaviour
{
    public float rotationSpeed = 50f;  // Velocidad de rotación
    public float floatAmplitude = 0.5f; // Altura máxima de flotación
    public float floatSpeed = 2f;  // Velocidad de subida y bajada

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Rotar sobre el eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Movimiento de flotación en el eje Y
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
