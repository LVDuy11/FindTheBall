using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public float horizontal = 0f;
    public float vertical = 0f;
    private void Awake()
    {
        InputManager.instance = this;
    }

    private void Update()
    {
        this.GetInputMovement();
    }

    public virtual void GetInputMovement()
    {
        this.horizontal = Input.GetAxis("Horizontal");
        this.vertical = Input.GetAxis("Vertical");
    }
}
