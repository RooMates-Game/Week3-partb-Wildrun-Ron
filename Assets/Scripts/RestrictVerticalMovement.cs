using UnityEngine;

public class RestrictVerticalMovement : MonoBehaviour
{
    private Camera mainCamera;
    private float spawnYPosition; // Store the player's initial Y position

    void Start()
    {
        mainCamera = Camera.main;
        spawnYPosition = transform.position.y; // Save the initial Y position of the player
    }

    void Update()
    {
        Vector3 playerPosition = transform.position;

        // Get the top and bottom boundaries of the screen in world space
        float screenTop = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        // Limit the player's position to the screen bounds and their spawn Y position
        if (playerPosition.y > screenTop)
        {
            playerPosition.y = screenTop;
        }
        else if (playerPosition.y < spawnYPosition) // Prevent moving below spawn position
        {
            playerPosition.y = spawnYPosition;
        }

        transform.position = playerPosition;
    }
}
