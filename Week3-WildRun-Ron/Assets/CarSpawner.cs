using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] carPrefabs; // Array of car prefabs to spawn

    [SerializeField]
    private float spawnInterval = 3f; // Time interval between spawns

    [SerializeField]
    private Vector3 movementDirection = Vector3.right; // Direction of car movement

    [SerializeField]
    private float carSpeed = 5f; // Speed of the cars

    private void Start()
    {
        // Start spawning cars repeatedly
        InvokeRepeating(nameof(SpawnCar), 0f, spawnInterval);
    }

    private void SpawnCar()
    {
        if (carPrefabs.Length == 0) return;

        // Randomly select a car prefab
        GameObject carToSpawn = carPrefabs[Random.Range(0, carPrefabs.Length)];

        // Use the prefab's default rotation
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRotation = carToSpawn.transform.rotation;

        // Instantiate the car prefab
        GameObject newCar = Instantiate(carToSpawn, spawnPosition, spawnRotation);

        // Set the car's movement direction and speed
        CarMover carMover = newCar.GetComponent<CarMover>();
        if (carMover != null)
        {
            carMover.SetMovement(movementDirection, carSpeed);
        }
    }
}
