using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    [Tooltip("How many meters to move per key press.")]
    private float stepDistance = 1;

    private void Awake()
    {
        // Auto-bind actions if no bindings are set
        if (moveRight.bindings.Count == 0)
            moveRight.AddBinding("<Keyboard>/rightArrow");

        if (moveLeft.bindings.Count == 0)
            moveLeft.AddBinding("<Keyboard>/leftArrow");

        if (moveUp.bindings.Count == 0)
            moveUp.AddBinding("<Keyboard>/upArrow");

        if (moveDown.bindings.Count == 0)
            moveDown.AddBinding("<Keyboard>/downArrow");
    }

    private void OnEnable()
    {
        moveRight.Enable();
        moveLeft.Enable();
        moveUp.Enable();
        moveDown.Enable();
    }

    private void OnDisable()
    {
        moveRight.Disable();
        moveLeft.Disable();
        moveUp.Disable();
        moveDown.Disable();
    }

    void Update()
    {
        // Move right if the key was pressed this frame
        if (moveRight.WasPressedThisFrame())
        {
            transform.position += new Vector3(stepDistance, 0, 0);
        }

        // Move left if the key was pressed this frame
        if (moveLeft.WasPressedThisFrame())
        {
            transform.position += new Vector3(-stepDistance, 0, 0);
        }

        // Move up if the key was pressed this frame
        if (moveUp.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, stepDistance, 0);
        }

        // Move down if the key was pressed this frame
        if (moveDown.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, -stepDistance, 0);
        }
    }
}
