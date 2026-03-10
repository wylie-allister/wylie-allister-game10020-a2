using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public float moveSpeed = 4f;

    CharacterController controller;

    public InputActionReference moveInput;
    public InputActionReference hitInput;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        

    }

    void PlayerMove()
    {
        Vector2 moveDirection = moveInput.action.ReadValue<Vector2>();

        Vector3 move = Vector3.right * moveDirection.x + Vector3.forward * moveDirection.y;
        Vector3 moveVelo = move * moveSpeed;

        controller.Move(moveVelo * Time.deltaTime);
    }
}
