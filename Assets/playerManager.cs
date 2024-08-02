using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    CameraManager cameraManager;
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;
    // Start is called before the first frame update
    private void Awake()
    {
        transform.localScale = Vector3.one * 0.0016f;
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        cameraManager = FindAnyObjectByType<CameraManager>();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInputs();
    }
    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();


    }
    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }
}
