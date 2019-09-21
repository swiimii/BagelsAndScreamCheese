using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject swordAttack;
    private float movementDeadzone = .1f;

    // FixedUpdate called 60 times per second
    void FixedUpdate()
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

    // Called once every frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && swordAttack.GetComponent<SwordBehavior>().isAttacking == false)
        {
            swordAttack.SetActive(true);
            StartCoroutine(swordAttack.GetComponent<SwordBehavior>().Attack());
        }
    }
}
