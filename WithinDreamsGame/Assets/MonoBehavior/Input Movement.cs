using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMovement : MonoBehaviour
{

    PlayerInput playerInput;

    InputAction moveAction;

    [SerializeField] float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        Vector2 dircetion = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(dircetion.x, 0, dircetion.y) * speed * Time.deltaTime;
    }


}

