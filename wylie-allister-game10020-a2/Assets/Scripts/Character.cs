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

        Vector3 hVelo = new Vector3(moveVelo.x, 0f, moveVelo.z);
        if (hVelo.sqrMagnitude > 0.001f)
        {
            Quaternion tRotate = Quaternion.LookRotation(hVelo);
            transform.rotation = Quaternion.Slerp(transform.rotation, tRotate, 10f * Time.deltaTime);
        }
    }
}
