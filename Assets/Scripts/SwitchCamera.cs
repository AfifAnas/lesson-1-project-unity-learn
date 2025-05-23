using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Camera mainCamera;
    public Camera secondCamera;
    public InputAction switchCameraAction;

    private void OnEnable() // set enable camera
    {
        switchCameraAction.Enable();
        switchCameraAction.performed += OnSwitchCamera;
    }

    private void OnDisable() // set disable camera
    {
        switchCameraAction.performed -= OnSwitchCamera;
        switchCameraAction.Disable();
    }

    void Start()
    {
        SetInitialCameraState();
    }

    void SetInitialCameraState() // set first camera
    {
        mainCamera.gameObject.SetActive(true);
        secondCamera.gameObject.SetActive(false);
    }

    void OnSwitchCamera(InputAction.CallbackContext context) // input switch camera
    {
        bool switchToMain = secondCamera.gameObject.activeSelf;

        mainCamera.gameObject.SetActive(switchToMain);
        secondCamera.gameObject.SetActive(!switchToMain);
    }
}
