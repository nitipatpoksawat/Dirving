using UnityEngine;
using UnityEngine.InputSystem;  

public class CarController : MonoBehaviour
{
    InputAction moveAction;
    [SerializeField] 
    float speed = 1000f;
    [SerializeField]
    float turnSpeed = 45f;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Player/Move");
    }

    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 verDirection = new Vector3(0, 0, moveInput.y);
        Vector3 horDirection = new Vector3(0,moveInput.x, 0);
        transform.Translate(verDirection * speed * Time.deltaTime);
        transform.Rotate(horDirection * turnSpeed * Time.deltaTime);
    }
}
