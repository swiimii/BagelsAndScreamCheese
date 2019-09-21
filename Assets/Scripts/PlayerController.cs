using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementDeadzone = .1f;

    // Update is called once per frame
    void Update()
    {
        // Get Movement
        var movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Mathf.Abs(movementInput.x) > movementDeadzone || Mathf.Abs(movementInput.y) > movementDeadzone)
        {
            // Vector magnitude won't exceed 1
            if(movementInput.magnitude > 1)
            {
                movementInput.Normalize();
            }

            // Send to playerbehavior
            GetComponent<PlayerBehavior>().Move(movementInput);
        }
    }
}
