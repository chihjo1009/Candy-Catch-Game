using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f;
    private float moveValue = 0f;
    private MyActions.PlayerActions playerActions;

    private void Awake()
    {
        MyActions actions = new MyActions();
        playerActions = actions.PlayerActions;

        playerActions.MoveLeftRight.performed += ctx => moveValue = ctx.ReadValue<float>();
        playerActions.MoveLeftRight.canceled += ctx => moveValue = 0;
    }

    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * moveValue * speed * Time.deltaTime);
    }
}
