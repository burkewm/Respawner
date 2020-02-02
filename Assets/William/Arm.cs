using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Arm : MonoBehaviour
{
    public Animator animator;
    PlayerControls controls;
    Vector2 move;
    bool liftHand = false;
    bool lowerHand = false;
    // Start is called before the first frame update
    bool closedThumb = false;
    bool closedIndex = false;
    bool closedMiddle = false;
    bool closedRing = false;
    bool closedPinky = false;
    bool isRotate = false;

    bool isGrabbing = false;


    public Transform grabTransform;
    public GetGrab gitGrab;
    public GameObject heldObj;


    void Awake()
    {
        controls = new PlayerControls();
        controls.Arm.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Arm.Move.canceled += ctx => move = Vector2.zero;

        controls.Arm.KeyboardMovement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Arm.KeyboardMovement.canceled += ctx => move = Vector2.zero;

        controls.Arm.Rotate.performed += ctx => isRotate = true;
        controls.Arm.Rotate.canceled += ctx => isRotate = false;

        controls.Arm.LiftHand.performed += ctx => liftHand = true;
        controls.Arm.LiftHand.canceled += ctx => liftHand = false;

        controls.Arm.LowerHand.performed += ctx => lowerHand = true;
        controls.Arm.LowerHand.canceled += ctx => lowerHand = false;

        controls.Arm.CloseThumb.performed += ctx => closedThumb = true;
        controls.Arm.CloseThumb.canceled += ctx => closedThumb = false;

        controls.Arm.CloseIndex.performed += ctx => closedIndex = true;
        controls.Arm.CloseIndex.canceled += ctx => closedIndex = false;

        controls.Arm.CloseMiddle.performed += ctx => closedMiddle = true;
        controls.Arm.CloseMiddle.canceled += ctx => closedMiddle = false;

        controls.Arm.CloseRing.performed += ctx => closedRing = true;
        controls.Arm.CloseRing.canceled += ctx => closedRing = false;

        controls.Arm.ClosePinky.performed += ctx => closedPinky = true;
        controls.Arm.ClosePinky.canceled += ctx => closedPinky = false;

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

        

        if (liftHand)
        {
            LiftHand();
        }
        if (lowerHand)
        {
            LowerHand();
        }
        if (isRotate)
        {
            Vector3 r = new Vector3(0, 25, 0) * Time.deltaTime;
            this.transform.Rotate(r);
        }

        if(closedThumb && closedIndex && closedMiddle && closedMiddle && closedRing && closedPinky)
        {
            //TO GRAB
            animator.SetBool("isClosed", true);
            Debug.Log("Grab Attempt");
            GrabObject();

        } else
        {
            animator.SetBool("isClosed", false);
            DropObject();

        }
        //else
        //{
        //    isGrabbing = false;
        //  //  DropObject();
        //}
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

    public void GrabObject()
    {
        if (gitGrab.hoveredObj != null)
        {
            gitGrab.hoveredObj.transform.position = grabTransform.position;
            gitGrab.hoveredObj.transform.rotation = grabTransform.rotation;
            gitGrab.hoveredObj.transform.parent = grabTransform;
            gitGrab.hoveredObj.GetComponent<Rigidbody>().isKinematic = true;

            
        }
    }
    public void DropObject()
    {
        if (gitGrab.hoveredObj != null)
        {
            gitGrab.hoveredObj.GetComponent<Rigidbody>().isKinematic = false;
            gitGrab.hoveredObj.transform.parent = null;
            
            gitGrab.hoveredObj = null;
            
        }
    }
}
