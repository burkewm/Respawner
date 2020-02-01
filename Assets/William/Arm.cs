using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Arm : MonoBehaviour
{
    
    PlayerControls controls;
    Vector2 move;
    bool liftHand = false;
    bool lowerHand = false;
    // Start is called before the first frame update

     void Awake()
    {
        controls = new PlayerControls();
        controls.Arm.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Arm.Move.canceled += ctx => move = Vector2.zero;

        controls.Arm.LiftHand.performed += ctx => liftHand = true;
        controls.Arm.LiftHand.canceled += ctx => liftHand = false;

        controls.Arm.LowerHand.performed += ctx => lowerHand = true;
        controls.Arm.LowerHand.canceled += ctx => lowerHand = false;
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m = new Vector3(-move.x, 0, -move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
        if (liftHand)
        {
            LiftHand();
        }
        if (lowerHand)
        {
            LowerHand();
        }
    }
    public void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Fire!");
    }
    


    public void OnMovement(InputAction.CallbackContext context)
    {
        var axis = context.ReadValue<Vector2>();
        var newAxis = new Vector2(axis.x, axis.y) * Time.deltaTime;
        Debug.LogFormat("Moving to direction {0}", axis);
    }

    public void LiftHand()
    {
        transform.position += new Vector3(0, 0.5f, 0) * Time.deltaTime;
    }
    public void LowerHand()
    {
        transform.position += new Vector3(0, -0.5f, 0) * Time.deltaTime;
    }
}
