using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField]
    private Vector3 movementDirection = Vector3.right; // Default movement direction
    private float speed = 5f; // Default speed

    void Update()
    {
        // Move the car in the specified direction
        transform.position += movementDirection.normalized * speed * Time.deltaTime;
    }

    public void SetMovement(Vector3 direction, float newSpeed)
    {
        movementDirection = direction;
        speed = newSpeed;
    }

    private void OnBecameInvisible()
    {
        // Destroy the car when it goes out of the camera's view
        Destroy(gameObject);
    }
}
