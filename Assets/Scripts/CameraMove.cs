using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move;
    public Scene currentS;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Arm.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Arm.Move.canceled += ctx => move = Vector2.zero;

        controls.Arm.KeyboardMovement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Arm.KeyboardMovement.canceled += ctx => move = Vector2.zero;

        controls.Arm.Reset.performed += ctx => Reload();
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m = new Vector3(-move.x, 0, -move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    void Reload()
    {
        Debug.Log("restet");
        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentS.ToString());
    }
}
