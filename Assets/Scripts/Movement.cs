using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [Header("Movement Settings")]
    public float Speed = 5f;
    public GameObject Player;
    
    [Header("Button Control")]
    public bool isUpButton = true; // Set this to true for Up button, false for Down button
    
    // Button press state
    private bool isPressed = false;
    
    // Input System references
    private Keyboard keyboard;

    void Start()
    {
        // Get keyboard reference
        keyboard = Keyboard.current;
    }

    void Update()
    {
        HandleMovement();
    }
    
    void HandleMovement()
    {
        if (Player == null) return;
        
        float moveDirection = 0f;
        
        // Handle keyboard input first
        if (keyboard != null)
        {
            if (keyboard.upArrowKey.isPressed)
            {
                moveDirection = 1f;
            }
            else if (keyboard.downArrowKey.isPressed)
            {
                moveDirection = -1f;
            }
        }
        
        // Handle button input (only if no keyboard input)
        if (moveDirection == 0f && isPressed)
        {
            moveDirection = isUpButton ? 1f : -1f;
        }
        
        // Apply movement
        if (moveDirection != 0f)
        {
            Player.transform.Translate(0, moveDirection * Speed * Time.deltaTime, 0);
        }
    }

    // Button event handlers
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}