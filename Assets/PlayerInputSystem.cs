using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSystem : MonoBehaviour
{
    [SerializeField] PlayerControler playerControler;

    public void WalkRight(InputAction.CallbackContext context)
    {
        if (context.started || context.performed)
        {
            playerControler.WalkingRight = true;
        }
        else if (context.canceled)
        {
            playerControler.WalkingRight = false;
        }
    }
    public void WalkLeft(InputAction.CallbackContext context)
    {
        if (context.started || context.performed)
        {
            playerControler.WalkingLeft = true;

        }
        else if (context.canceled)
        {
            playerControler.WalkingLeft = false;
        }
    }
    public void WalkUp(InputAction.CallbackContext context)
        {
            if (context.started || context.performed)
            {
                playerControler.WalkingUp = true;
            }
            else if (context.canceled)
            {
                playerControler.WalkingUp = false;
            }
        }

        public void WalkDown(InputAction.CallbackContext context)
        {
            if (context.started || context.performed)
            {
                playerControler.WalkingDown = true;
            }
            else if (context.canceled)
            {
                playerControler.WalkingDown = false;
            }
        }
}
