using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private GameObject interactionItem;

    private Vector2 movementDirection;

    private void Start()
    {
        interactionItem = null;
    }
    private void FixedUpdate()
    {
        transform.position += (Vector3)(movementDirection * movementSpeed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Interaction")
        {
            interactionItem = collision.gameObject;
        }else if (collision.tag == "Mu")
        {

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Interaction")
        {
            interactionItem = null;
        }
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (!interactionItem)
                return;

            if (interactionItem.GetComponent<FlammableObject>())
            {
                interactionItem.GetComponent<FlammableObject>().TryIgnite();
                Debug.Log(interactionItem.name);

            }
        }
    }
}